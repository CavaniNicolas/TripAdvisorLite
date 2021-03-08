
import "./HomePage.css"
import React from "react";
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import UsersPage from './pages/UsersPage.js'
import ServicesPage from './pages/ServicesPage.js'
import ReviewsPage from './pages/ReviewsPage.js'
import AddServicePage from './pages/AddServicePage.js'

const HomePage = () => (
  <Router>
    <div>

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
        <Link to="/addservice">Add a service</Link>
      </div>


      <hr />

      <Route path="/users" component={UsersPage} />
      <Route path="/services" component={ServicesPage} />
      <Route path="/reviews" component={ReviewsPage} />.
      <Route path="/addservice" component={AddServicePage} />
    </div>
  </Router>
);

export default HomePage;