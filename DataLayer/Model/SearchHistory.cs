using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class SearchHistory
    {
        [Key]
        public string Username { get; set; }
        public string SearchedTerm { get; set; }
    }
}

