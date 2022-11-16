using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class ActorRating
    {
        [Key]
        public string NConst { get; set; }
        public decimal Rating { get; set; }
    }
}

