using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class User
    {
        public string? Url;

        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}


