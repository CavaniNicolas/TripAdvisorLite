using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int Note { get; set; }
        public int UserId { get; set; }
        public string Date { get; set; }
        public int ServiceId { get; set; }
        public string Text { get; set; }

        public Review()
        {
            ReviewId = 0;
            Note = 0;
            UserId = 0;
            Date = " ";
            ServiceId = 0;
            Text = " ";
        }

        public override string ToString()
        {
            return this.ReviewId + " " + this.Note + " " + this.Text;
        }
    }
}
