using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DalDto.ModelsDto;
using DalDto;

namespace WebApplication1.Controllers
{
    public class ProductDtoController : Controller
    {
        RepositoryDto repo = new RepositoryDto();
        [HttpGet("/allproductsdto")]
        public IEnumerable<ProductDto> GetAllProductsDto()
        {
            return repo.GetAllProductsDto();
        }
    }
}
