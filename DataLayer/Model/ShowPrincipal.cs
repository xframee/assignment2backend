using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class ShowPrincipal
    {
        [Key]
        public string TConst { get; set; }
        public string NConst { get; set; }
        public int Ordering { get; set; }
        public string? Category { get; set; }
        public string? Job { get; set; }

    }

}
