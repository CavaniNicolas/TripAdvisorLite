
import Header from '../components/header/Header.js';
import Reviews from '../components/review/Reviews.js';

function ReviewsPage() {                     

  return (
    <section className="app-container">
      <Header />
      <section className="app-content">

        <Reviews />

        <h1>fin</h1>
      </section>

      <div className="overlay"></div>
    </section>
  );
}

export default ReviewsPage;
