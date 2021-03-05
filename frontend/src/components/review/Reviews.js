
import { useState, useEffect } from 'react';
import Review from './Review.js'

function Reviews () {

	const [reviewData, setReviewData] = useState([]);
	useEffect(() => 
	  fetch((window.location.href).replace('3000','44398').replace('http','https'))
		.then(response => response.json())
		.then(json => setReviewData(json))
	  ,[]);
  
	let ReviewList = reviewData.map(review => <Review id={review.reviewId} userid={review.userId} serviceid={review.serviceId}
	  note={review.note} text={review.text} date={review.date}
	  key={review.reviewId}
	/>);

    return (
		<div className="row">
		  <h1>reviews</h1>
		  <div className="col-1">reviewid</div>
		  <div className="col-1">userid</div>
		  <div className="col-1">serviceid</div>
		  <div className="col-1">note</div>
		  <div className="col-2">text</div>
		  <div className="col-2">date</div>
		  <h1> </h1>
		  {ReviewList}
		</div>
    );
}

export default Reviews;
