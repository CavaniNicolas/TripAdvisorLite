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
    public class OrderController : ControllerBase
    {
        BikeStoreRepository repo = new BikeStoreRepository();

        [HttpGet("/orderbycustomerid")]
        public Order GetOrderByCustomerId(int cid)
        {
            return repo.GetOrderByCustomerId(cid);
        }
    }
}