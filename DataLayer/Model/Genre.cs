using System;
using System.ComponentModel.DataAnnotations;


namespace DataLayer.Model
{
    public class Genre
    {
        [Key]
        public string TConst { get; set; }
        public string MovieGenre { get; set; }
    }
}

