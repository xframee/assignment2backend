using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class KnownFor
    {
        [Key]
        public string NConst { get; set; }
        public string Titles { get; set; }
    }
}
