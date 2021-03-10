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
        [HttpGet("/insertuser")]
        public void InsertUser(int id, string name)
        {
            repo.InsertUser(id, name);
        }

        [HttpGet("/services")]
        public IEnumerable<Service> GetServiceByAny(int id = -1, string adress = null, string name = null, string type = null)
        {
            return repo.GetServiceByAny(id, adress, name, type);
        }
        [HttpGet("/insertservice")]
        public void InsertService(int id, string adress, string name, string type)
        {
            repo.InsertService(id, adress, name, type);
        }

        [HttpGet("/reviews")]
        public IEnumerable<Review> GetReviewByAny(int id = -1, int userid = -1, int serviceid = -1, int note = -1, string texte = null, string date = null)
        {
            return repo.GetReviewByAny(id,userid,serviceid,note,texte,date);
        }
        [HttpGet("/insertreview")]
        public void InsertReview(int id, int userid, int serviceid, int note, string texte, string date)
        {
            repo.InsertReview(id, userid, serviceid, note, texte, date);
        }


    }
}
