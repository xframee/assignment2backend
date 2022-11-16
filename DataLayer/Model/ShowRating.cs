using System;
using System.ComponentModel.DataAnnotations;


namespace DataLayer.Model
{
    public class ShowRating
    {
        [Key]
        public string TConst { get; set; }
        public decimal AverageRating { get; set; }
        public int NumVotes { get; set; }
    }
}

