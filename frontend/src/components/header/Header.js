import './Header.css';
import "./NavBar.css";
import 'bootstrap/dist/css/bootstrap.css';

import { Link } from "react-router-dom";

function Header() {

    return (
        <header className="app-header">
            <h1 className="Logo">Trip Advisor</h1>

            <nav>
                <div id="menu-outer">
                <div className="table">
                    <ul id="horizontal-list">
                        <li>
                        <Link to="/users">Users</Link>
                        </li>
                        <li>
                        <Link to="/services">Services</Link>
                        </li>
                        <li>
                        <Link to="/reviews">Reviews</Link>
                        </li>
                    </ul>
                </div>
                </div>
            </nav>



        </header>
    );
}
export default Header;