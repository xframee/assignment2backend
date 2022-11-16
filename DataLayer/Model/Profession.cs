using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class Profession
    {
        [Key]
        public string NConst { get; set; }
        public string PersonProfession { get; set; }
    }
}

