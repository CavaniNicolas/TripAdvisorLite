using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        //public List<Review> ReviewList { get; set; }

        public User()
        {
            UserId = 0;
            Username = " ";
            //ReviewList = new List<Review>();
        }
    }
}
