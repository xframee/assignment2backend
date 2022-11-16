using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class UserBookmark
    {
        [Key]
        public string Username { get; set; }
        public string TConst { get; set; }
    }
}


