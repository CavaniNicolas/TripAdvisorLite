using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
    public class ProductController : ControllerBase
    {
        BikeStoreRepository repo = new BikeStoreRepository();
        [HttpGet("/allproducts")]
        public IEnumerable<Product> GetAllProducts()
        {
            return repo.GetAllProducts();
        }

        [HttpGet("/productbyid")]
        public Product GetProductById(int pid)
        {
            return repo.GetProductById(pid);
        }

        [HttpGet("/productbyname")]
        public Product GetProductByName(string pname)
        {
            return repo.GetProductByName(pname);
        }
    }
}
