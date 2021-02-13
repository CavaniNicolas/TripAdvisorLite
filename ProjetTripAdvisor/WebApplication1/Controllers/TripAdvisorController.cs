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

    }
}
