using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class TripAdvisorRepository
    {
        public IEnumerable<User> GetAllUsers()
        {
            using (var context = new TripAdvisorContext())
            {
                User usertmp = new User();
                List<User> listetmp = new List<User>();
                listetmp.Add(usertmp);
                //return listetmp;

                return context.Users.ToList();
            }
        }
    }
}
