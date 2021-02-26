using DAL.Models;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;


namespace DAL
{
    public interface ITripAdvisorRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        IEnumerable<Review> GetAllReviews();
        Review GetReviewById(int id);
        IEnumerable<Service> GetAllServices();
        Service GetServiceById(int id);
        IEnumerable<Service> GetServiceByName(string name);
    }
    public class TripAdvisorRepository : ITripAdvisorRepository
    {
        public IEnumerable<User> GetAllUsers()
        {
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";
            Getter g = new Getter();

            return g.GetAllUsers(cb);
        }
        public User GetUserById(int id)
        {
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";
            Getter g = new Getter();

            return g.GetUserById(cb,id);
        }
        public IEnumerable<Review> GetAllReviews()
        {
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";
            Getter g = new Getter();

            return g.GetAllReviews(cb);
        }
        public Review GetReviewById(int id)
        {
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";
            Getter g = new Getter();

            return g.GetReviewById(cb,id);
        }
        public IEnumerable<Service> GetAllServices()
        {
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";
            Getter g = new Getter();

            return g.GetAllServices(cb);
        }
        public Service GetServiceById(int id)
        {
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";
            Getter g = new Getter();

            return g.GetServiceById(cb,id);
        }
        public IEnumerable<Service> GetServiceByName(string name)
        {
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";
            Getter g = new Getter();

            return g.GetServiceByName(cb,name);
        }
    }
}
