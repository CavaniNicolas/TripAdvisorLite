using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int Note { get; set; }
        //public User Poster { get; set; }
        public string Date { get; set; }
        //public Service Service { get; set; }
        public string Text { get; set; }

        public Review()
        {
            ReviewId = 0;
            Note = 0;
            //Poster = null;
            Date = " ";
            //Service = null;
            Text = " ";
        }
    }
}
