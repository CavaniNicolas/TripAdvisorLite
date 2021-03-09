
import React from "react";
import { BrowserRouter as Router, Route } from "react-router-dom";
import Header from './components/header/Header.js';
import UsersPage from './pages/UsersPage.js'
import ServicesPage from './pages/ServicesPage.js'
import ReviewsPage from './pages/ReviewsPage.js'
import AddServicePage from './pages/AddServicePage.js'

const HomePage = () => (
  <Router>
    <body>
      <Header />

      <div class="content">
        <Route path="/users" component={UsersPage} />
        <Route path="/services" component={ServicesPage} />
        <Route path="/reviews" component={ReviewsPage} />
        <Route path="/addservice" component={AddServicePage} />
      </div>

    </body>

  </Router>
);

export default HomePage;