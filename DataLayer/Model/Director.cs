using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class Director
    {
        [Key]
        public string TConst { get; set; }
        public string NConst { get; set; }
    }
}