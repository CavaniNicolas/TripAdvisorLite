﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("/allusers")]
        public IEnumerable<User> GetAllUsers()
        {
            return repo.GetAllUsers();
        }
    }
}