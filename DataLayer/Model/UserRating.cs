using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class UserRating
    {
        [Key]
        public string Username { get; set; }
        public string TConst { get; set; }
        public int Rating { get; set; }

    }
}


