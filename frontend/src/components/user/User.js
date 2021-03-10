import { useState, useEffect } from 'react';
import './User.css';
import 'bootstrap/dist/css/bootstrap.css';
import { Link } from "react-router-dom";

function User({id,name}) {

    var link = "/reviews?userid="+id;
    // <Route path = {link} component={LaReview} />

    const [reviewData, setReviewData] = useState([]);
	useEffect(() => 
	  fetch('https://localhost:44398/reviews?userid='+id)
		.then(response => response.json())
		.then(json => setReviewData(json))
	  ,[]);
    

    return (

        <div className="user">
            <div className="col-2">{id}</div>
            <div className="col-2">{name}</div>
            <div className="col-2"><Link to={link}>{reviewData.length}</Link></div>
        </div>

    );
}
export default User;