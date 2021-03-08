using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TripAdvisorController : Controller
    {
        private readonly ITripAdvisorRepository repo;

        public TripAdvisorController(ITripAdvisorRepository repo)
        {
            this.repo = repo;
        }

        [HttpGet("/users")]
        public IEnumerable<User> GetUserByAny(int id = -1, string name = null)
        {
            return repo.GetUserByAny(id, name);
        }

        [HttpGet("/services")]
        public IEnumerable<Service> GetServiceByAny(int id = -1, string adress = null, string name = null, string type = null)
        {
            return repo.GetServiceByAny(id, adress, name, type);
        }

        [HttpGet("/reviews")]
        public IEnumerable<Review> GetReviewByAny(int id = -1, int userid = -1, int serviceid = -1, int note = -1, string texte = null, string date = null)
        {
            return repo.GetReviewByAny(id,userid,serviceid,note,texte,date);
        }


    }
}
