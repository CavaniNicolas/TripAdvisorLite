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
        public IEnumerable<User> GetAllUsers()
        {
            return repo.GetAllUsers();
        }
        [HttpGet("/user")]
        public User GetUserById(int id)
        {
            return repo.GetUserById(id);
        }

        [HttpGet("/services")]
        public IEnumerable<Service> GetAllServices()
        {
            return repo.GetAllServices();
        }
        [HttpGet("/service")]
        public Service GetServiceById(int id)
        {
            return repo.GetServiceById(id);
        }
        [HttpGet("/servicebyname")]
        public IEnumerable<Service> GetServiceByName(string name)
        {
            return repo.GetServiceByName(name);
        }
        [HttpGet("/servicebyany")]
        public IEnumerable<Service> GetServiceByAny(int id = -1, string adress = null, string name = null)
        {
            return repo.GetServiceByAny(id, adress, name);
        }

        [HttpGet("/reviews")]
        public IEnumerable<Review> GetAllReviews()
        {
            return repo.GetAllReviews();
        }
        [HttpGet("/review")]
        public Review GetReviewById(int id)
        {
            return repo.GetReviewById(id);
        }
        [HttpGet("/reviewbyany")]
        public IEnumerable<Review> GetReviewByAny(int id = -1, int userid = -1, int serviceid = -1, int note = -1, string texte = null, string date = null)
        {
            return repo.GetReviewByAny(id,userid,serviceid,note,texte,date);
        }


    }
}
