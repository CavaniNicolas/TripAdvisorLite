import './Review.css';
import 'bootstrap/dist/css/bootstrap.css';
import { BrowserRouter as Router, Route, Link } from "react-router-dom";


function Review({id,userid,serviceid,note,text,date}) {

    var link_user =  "/users?id="+userid;
    var link_service = "/services?id="+serviceid;

    return (
        <div className="row">
            <div className="col-1">{id}</div>
            <div className="col-1"><Link to={link_user}>{userid}</Link></div>
            <div className="col-1"><Link to={link_service}>{serviceid}</Link></div>
            <div className="col-1">{note}</div>
            <div className="col-2">{text}</div>
            <div className="col-2">{date}</div>
        </div>
    );
}
export default Review;