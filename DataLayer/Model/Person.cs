using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class Person
    {
        [Key]
        public string NConst { get; set; }
        public string? Name { get; set; }
        public string? BirthYear { get; set; }
        public string? DeathYear { get; set; }
    }
}

