import React from 'react';
import ReactDOM from 'react-dom';
import './css/index.css';

import { BrowserRouter as Router, Route } from "react-router-dom";

import reportWebVitals from './reportWebVitals';

import UsersPage from './pages/UsersPage.js'
import ServicesPage from './pages/ServicesPage.js'
import ReviewsPage from './pages/ReviewsPage.js'
import AddServicePage from './pages/AddServicePage.js'

ReactDOM.render(
  <React.StrictMode>

    <Router>
    <div class="content">
        <Route path="/users" component={UsersPage} />
        <Route path="/services" component={ServicesPage} />
        <Route path="/reviews" component={ReviewsPage} />
        <Route path="/addservice" component={AddServicePage} />
    </div>
    </Router>
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
