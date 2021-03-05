import { useState, useEffect } from 'react';
import './Service.css';
import 'bootstrap/dist/css/bootstrap.css';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";


function Service({id,name,adress}) {
    var link =  "/reviews?serviceid="+id;

    const [reviewData, setReviewData] = useState([]);
	useEffect(() => 
	  fetch('https://localhost:44398/reviews?serviceid='+id)
		.then(response => response.json())
		.then(json => setReviewData(json))
	  ,[]);
    
    const MoyReviews = (reviewlist) => {
        let rep = 0;
        let i = 0;
        reviewlist.forEach(review => {
          rep += review.note;
          i++;
        });
        if (i === 0){
          i=1;
        }
        return (rep/i);
    }

    return (
        <div className="service">
            <div className="col-1">{id}</div>
            <div className="col-2">{name}</div>
            <div className="col-3">{adress}</div>
            <div className="col-1">{MoyReviews(reviewData)}/5</div>
            <div className="col-2 review-button"><Link to={link}>Reviews</Link></div>
        </div>

    );
}
export default Service;