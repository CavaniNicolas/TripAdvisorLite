
import './ServicesPage.css';
import Header from '../components/header/Header.js';
import Services from '../components/service/Services.js';

function ServicesPage() {                     

  return (
    <section className="app-container">
      <Header />
      <section className="app-content">

        <Services />

        <h1>fin</h1>
      </section>

      <div className="overlay"></div>
    </section>
  );
}

export default ServicesPage;