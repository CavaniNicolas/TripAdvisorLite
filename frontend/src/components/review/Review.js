import './Review.css';
import 'bootstrap/dist/css/bootstrap.css';
import { Link } from "react-router-dom";
import { useState, useEffect } from 'react';


function Review({id,userid,serviceid,note,text,date}) {

    var link_user =  "/users?id="+userid;
    var link_service = "/services?id="+serviceid;

    const [userData, setUserData] = useState([]);
	useEffect(() => 
	  fetch("https://localhost:44398/users?id="+userid)
		.then(response => response.json())
		.then(json => setUserData(json))
      ,[]);
      
    const [serviceData, setServiceData] = useState([]);
    useEffect(() => 
    fetch("https://localhost:44398/services?id="+serviceid)
        .then(response => response.json())
        .then(json => setServiceData(json))
    ,[]);

    let username = "";
    let servicename = "";
    if (userData[0])
        username = userData[0].username;
    if (serviceData[0])
        servicename = serviceData[0].name;

    return (
        <div className="row">
            <div className="col-1">{id}</div>
            <div className="col-1"><Link to={link_user}>{username}</Link></div>
            <div className="col-1"><Link to={link_service}>{servicename}</Link></div>
            <div className="col-1">{note}</div>
            <div className="col-2">{text}</div>
            <div className="col-2">{date}</div>
        </div>
    );
}
export default Review;