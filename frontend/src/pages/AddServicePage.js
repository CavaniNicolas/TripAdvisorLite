import Header from '../components/header/Header.js';
import AddService from '../components/service/AddService.js';

function AddServicePage() {                     

  return (
    <section className="app-container">
      <Header/>
      <section className="app-content">

        <AddService/>

        <h1>fin</h1>
      </section>

      <div className="overlay"></div>
    </section>
  );
}

export default AddServicePage;