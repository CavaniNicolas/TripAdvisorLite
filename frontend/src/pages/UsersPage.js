
import Header from '../components/header/Header.js';
import Users from '../components/user/Users.js';

function UsersPage() {                     

  return (
    <section className="app-container">
      <Header />
      <section className="app-content">

        <Users />

        <h1>fin</h1>
      </section>

      <div className="overlay"></div>
    </section>
  );
}

export default UsersPage;