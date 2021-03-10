using DAL.Models;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;


namespace DAL
{
    public interface ITripAdvisorRepository
    {

        IEnumerable<User> GetUserByAny(int id, string name);
        void InsertUser(int id, string name);
        IEnumerable<Review> GetReviewByAny(int id, int userid, int serviceid, int note, string texte, string date);
        void InsertReview(int id, int userid, int serviceid, int note, string texte, string date);
        IEnumerable<Service> GetServiceByAny(int id, string adress, string name, string type);
        void InsertService(int id, string adress, string name, string type);
    }
    public class TripAdvisorRepository : ITripAdvisorRepository
    {
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
        public void InsertUser(int id, string name)
        {
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";
            Getter g = new Getter();
            g.InsertUser(cb, id, name);
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
        public void InsertReview(int id, int userid, int serviceid, int note, string texte, string date)
        {
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";
            Getter g = new Getter();
            g.InsertReview(cb, id, userid, serviceid, note, texte, date);
        }
        public IEnumerable<Service> GetServiceByAny(int id = -1, string adress = null, string name = null, string type = null)
        {
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";
            Getter g = new Getter();

            return g.GetServiceByAny(cb, id, adress, name, type);
        }
        public void InsertService(int id, string adress, string name, string type)
        {
            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";
            Getter g = new Getter();
            g.InsertService(cb, id, adress, name, type);
        }
    }
}
