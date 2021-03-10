using System;
using System.Collections.Generic;
using System.Text;

namespace DalDto.ModelsDto
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public decimal ListPrice { get; set; }
        public virtual CategoryDto CategoryDto { get; set; }
    }
}
