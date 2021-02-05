using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            return context.Users.ToList();
        }
    }
}
