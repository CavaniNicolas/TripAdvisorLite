
import React from "react";
import { BrowserRouter as Router, Route, Link } from "react-router-dom";
import UsersPage from './pages/UsersPage.js'
import ServicesPage from './pages/ServicesPage.js'
import ReviewsPage from './pages/ReviewsPage.js'

const HomePage = () => (
  <Router>
    <div>
      <ul>
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

      <hr />

      <Route path="/users" component={UsersPage} />
      <Route path="/services" component={ServicesPage} />
      <Route path="/reviews" component={ReviewsPage} />
    </div>
  </Router>
);

export default HomePage;