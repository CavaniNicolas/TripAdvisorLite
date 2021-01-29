using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class BikeStoreRepository
    {
        public IEnumerable<Product> GetAllProducts()
        {
            using (var context = new BikeStoreContext())
            {
                return context.Products.ToList();
            }
        }

        public Product GetProductById(int pid)
        {
            using (var context = new BikeStoreContext())
            {
                Product p = GetAllProducts().FirstOrDefault(item => item.ProductId == pid);
                Console.WriteLine(p.ProductName);
                return p;
            }
        }

        public Product GetProductByName(string pname)
        {
            using (var context = new BikeStoreContext())
            {
                Product p = GetAllProducts().FirstOrDefault(item => item.ProductName == pname);
                Console.WriteLine(p.ProductId);
                return p;
            }
        }

        public Order GetOrderByCustomerId(int cid)
        {
            using (var context = new BikeStoreContext())
            {
                Order o = context.Orders.ToList().FirstOrDefault(item => item.CustomerId == cid);
                Console.WriteLine(o.OrderId);
                foreach (OrderItem elmt in o.OrderItems)
                {
                    Console.WriteLine(elmt.ProductId + " : " + elmt.Quantity);
                }
                return o;
            }
        }
    }
}
