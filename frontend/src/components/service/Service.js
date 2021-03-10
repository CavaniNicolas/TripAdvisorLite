import { useState, useEffect } from 'react';
import './Service.css';
import 'bootstrap/dist/css/bootstrap.css';
import { Link } from "react-router-dom";

function Service({id,name,adress,type}) {
    var review_link =  "/reviews?serviceid="+id;
    var service_link =  "/services?id="+id;

    const [reviewData, setReviewData] = useState([]);
	useEffect(() => 
	  fetch('https://localhost:44398'+review_link)
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
          return ""
        }
        return (rep/i) + "/5";
    }

    return (

      <tbody>
        <tr>
          <th scope="row" className="col-1">{id}</th>
          <td className="col-3"><Link to={service_link}>{name}</Link></td>
          <td className="col-3">{adress}</td>
          <td className="col-2">{type}</td>
          <td className="col-1">{MoyReviews(reviewData)}⠀<Link to={review_link}>({reviewData.length}reviews)</Link></td>
        </tr>
      </tbody>

    );
}
export default Service;