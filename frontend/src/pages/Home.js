
import '../css/Home.css';
import Header from '../components/header/Header.js';
import Users from '../components/user/Users.js';
import Services from '../components/service/Services.js';
import Reviews from '../components/review/Reviews.js';
// import 'bootstrap/dist/css/bootstrap.css';

function Home() {                     

  return (
    <section className="app-container">
      <Header />
      <section className="app-content">   
        <Users />
        <Services />
        <Reviews />

        <h1>fin</h1>
      </section>
      <div className="overlay"></div>
    </section>
  );
}

export default Home;
