//import { useState, useEffect } from 'react';
import './Review.css';
import 'bootstrap/dist/css/bootstrap.css';


    function Review({id,userid,serviceid,note,text,date}) {
        return (
            <div className="row">
                <div className="col-1">{id}</div>
                <div className="col-1">{userid}</div>
                <div className="col-1">{serviceid}</div>
                <div className="col-1">{note}</div>
                <div className="col-2">{text}</div>
                <div className="col-2">{date}</div>
            </div>
        );
    }
    export default Review;