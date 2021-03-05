using DAL.Models;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;


namespace DAL
{
    public interface ITripAdvisorRepository
    {
        IEnumerable<User> GetAllUsers();
        User GetUserById(int id);
        IEnumerable<User> GetUserByAny(int id, string name);
        IEnumerable<Review> GetAllReviews();
        Review GetReviewById(int id);
        IEnumerable<Review> GetReviewByAny(int id, int userid, int serviceid, int note, string texte, string date);
        IEnumerable<Service> GetAllServices();
        Service GetServiceById(int id);
        IEnumerable<Service> GetServiceByName(string name);
        IEnumerable<Service> GetServiceByAny(int id, string adress, string name);
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
        public IEnumerable<User> GetUserByAny(int id = -1, string name = null)
        {
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";
            Getter g = new Getter();

            return g.GetUserByAny(cb, id, name);
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
        public IEnumerable<Review> GetReviewByAny(int id = -1, int userid = -1, int serviceid = -1, int note = -1, string texte = null, string date = null)
        {
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";
            Getter g = new Getter();

            return g.GetReviewByAny(cb, id, userid, serviceid, note, texte, date);
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

        public IEnumerable<Service> GetServiceByAny(int id = -1, string adress = null, string name = null)
        {
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";
            Getter g = new Getter();

            return g.GetServiceByAny(cb, id, adress, name);
        }
    }
}
