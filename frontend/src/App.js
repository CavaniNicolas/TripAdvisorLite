import './App.css';
import { useState, useEffect } from 'react';
import Header from './header/Header';
import User from './user/User';
import Service from './service/Service';
import Review from './review/Review';
import 'bootstrap/dist/css/bootstrap.css';

function App() {

  const [userData, setUserData] = useState([]);
  useEffect(() => 
    fetch('https://localhost:44398/users')
      .then(response => response.json())
      .then(json => setUserData(json))
    ,[]);

  let UserList = userData.map(user => <User id={user.userId} name={user.username} 
    key={user.userId}
  />);

  const [serviceData, setServiceData] = useState([]);
  useEffect(() => 
    fetch('https://localhost:44398/services')
      .then(response => response.json())
      .then(json => setServiceData(json))
    ,[]);

  let ServiceList = serviceData.map(service => <Service id={service.serviceId} name={service.name} adress={service.adress}
    key={service.serviceId}
  />);

  const [reviewData, setReviewData] = useState([]);
  useEffect(() => 
    fetch('https://localhost:44398/reviews')
      .then(response => response.json())
      .then(json => setReviewData(json))
    ,[]);

  let ReviewList = reviewData.map(review => <Review id={review.reviewId} userid={review.userId} serviceid={review.serviceId}
    note={review.note} text={review.text} date={review.date}
    key={review.reviewId}
  />);                       

  return (
    <section className="app-container">
      <Header />
      <section className="app-content">   
        <h1>users</h1>
        <div className="row">
          <div className="col-1">userid</div>
          <div className="col-1">username</div>
        </div>
        <h1> </h1>
        {UserList}

        <h1>services</h1>
        <div className="row">
          <div className="col-1">serviceid</div>
          <div className="col-1">name</div>
          <div className="col-4">adress</div>
        </div>
        <h1> </h1>
        {ServiceList}

        <h1>reviews</h1>
        <div className="row">
          <div className="col-1">reviewid</div>
          <div className="col-1">userid</div>
          <div className="col-1">serviceid</div>
          <div className="col-1">note</div>
          <div className="col-2">text</div>
          <div className="col-2">date</div>
        </div>
        <h1> </h1>
        {ReviewList}

        <h1>fin</h1>
      </section>
      <div className="overlay"></div>
    </section>
  );
}

export default App;
