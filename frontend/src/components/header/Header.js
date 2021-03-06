import './Header.css';
import "./NavBar.css";

import { Link } from "react-router-dom";

function Header() {

    return (
        <header className="app-header">

            <div className="logoBox" onClick={() => window.location.href="/services"}>
                <div className="logoWrap">
                    <h1 className="logo">Trip Advizor</h1>
                </div>
            </div>


            <div className="navBox">
                <nav className="navMenu">
                    <ul id="horizontal-list">
                        <li>
                            <Link className="navLink" to="/addservice">Add a service</Link>
                        </li>
                    </ul>
                </nav>
            </div>

        </header>
    );
}
export default Header;

