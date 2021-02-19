//import { useState, useEffect } from 'react';
import './User.css';
import 'bootstrap/dist/css/bootstrap.css';


function User({id,name}) {
    return (
        <div className="row">
            <div className="col-1">{id}</div>
            <div className="col-1">{name}</div>
        </div>
    );
}
export default User;