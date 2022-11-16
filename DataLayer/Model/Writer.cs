using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class Writer
    {
        [Key]
        public string TConst { get; set; }
        public string NConst { get; set; }
    }
}

