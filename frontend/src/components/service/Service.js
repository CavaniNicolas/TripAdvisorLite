//import { useState, useEffect } from 'react';
import './Service.css';
import 'bootstrap/dist/css/bootstrap.css';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";


function Service({id,name,adress}) {
    return (
        <div className="service">
            <div className="col-1">{id}</div>
            <div className="col-2">{name}</div>
            <div className="col-3">{adress}</div>
            <div className="col-2 review-button"><Link to="/reviews">Reviews</Link></div>
        </div>

    );
}
export default Service;