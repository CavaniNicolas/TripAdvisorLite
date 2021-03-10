using System;
using DalDto.ModelsDto;

namespace Business
{
    public class TVAculculator
    {
        public  void ShowPrices(ProductDto leproduit)
        {
            double HTprice = (double)leproduit.ListPrice;
            double TVArate = 0.2;
            if (leproduit.CategoryDto.CategoryId == 12 || leproduit.CategoryDto.CategoryName == "electric_bike")
                TVArate = 0.05;
            double TTCprice = HTprice * (1 + TVArate);
            double TVAprice = TTCprice - HTprice;

            Console.WriteLine("Prix HT:" + HTprice + ", Taux TVA:" + TVArate + ", Prix TTC:" + TTCprice + ", Prix de la TVA:" + TVAprice);
        }
    }
}
