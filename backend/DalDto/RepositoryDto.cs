using DAL.Models;
using DalDto.ModelsDto;
using System.Collections.Generic;
using System.Linq;

namespace DalDto
{
    public class RepositoryDto
    {
        public List<ProductDto> GetAllProductsDto()
        {
            using (var context = new BikeStoreContext())
            {
                List<ProductDto> list = new List<ProductDto>();
                foreach (Product p in context.Products.ToList())
                {
                    CategoryDto y = new CategoryDto();
                    y.CategoryId = p.CategoryId;
                    if(p.Category!=null)
                        y.CategoryName = p.Category.CategoryName;

                    ProductDto x = new ProductDto();
                    x.ProductId = p.ProductId;
                    x.ListPrice = p.ListPrice;
                    x.CategoryDto = y;

                    list.Add(x);
                }
                return list;
            }
        }

    }
}
