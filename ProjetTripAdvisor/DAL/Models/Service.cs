using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Adress { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }
        //public List<Review> ReviewList { get; set; }

        public Service()
        {
            ServiceId = 0;
            Name = " ";
            Adress = " ";
            Type = "";
        }

        public override string ToString()
        {
            return this.ServiceId + " " + this.Name + " " + this.Adress;
        }
    }
}
