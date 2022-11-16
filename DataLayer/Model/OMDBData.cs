using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model

{
    public class OMDBData
    {
        [Key]
        public string TConst { get; set; }
        public string Poster { get; set; }
        public string Plot { get; set; }
    }
}

