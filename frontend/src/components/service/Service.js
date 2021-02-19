//import { useState, useEffect } from 'react';
import './Service.css';
import 'bootstrap/dist/css/bootstrap.css';


function Service({id,name,adress}) {
    return (
        <div className="row">
            <div className="col-1">{id}</div>
            <div className="col-1">{name}</div>
            <div className="col-4">{adress}</div>
        </div>
    );
}
export default Service;