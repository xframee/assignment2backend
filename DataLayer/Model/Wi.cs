using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class Wi
    {
        [Key]
        public string TConst { get; set; }
        public string Word { get; set; }
        public string Field { get; set; }
        public string? Lexeme { get; set; }

    }

}
