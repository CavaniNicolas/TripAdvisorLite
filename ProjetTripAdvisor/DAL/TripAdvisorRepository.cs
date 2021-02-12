using DAL.Models;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;


namespace DAL
{
    public interface ITripAdvisorRepository
    {
        IEnumerable<User> GetAllUsers();
    }
    public class TripAdvisorRepository : ITripAdvisorRepository
    {
        private readonly TripAdvisorContext context;

        public TripAdvisorRepository(TripAdvisorContext context)
        {
            this.context = context;
        }
        public IEnumerable<User> GetAllUsers()
        {
            User usertmp = new User();
            List<User> listetmp = new List<User>();
            listetmp.Add(usertmp);
            //return listetmp;

            //return context.Users.ToList();

            var cb = new SqlConnectionStringBuilder();
            cb.DataSource = "tripadvisordb.database.windows.net";
            cb.UserID = "sheep";
            cb.Password = "ISIMAisima2021!";
            cb.InitialCatalog = "tripadvisorDB";
            QueriesSQL q = new QueriesSQL();
            Getter g = new Getter();


        }
    }
}
