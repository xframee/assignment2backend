using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class EpisodeInfo
    {
        [Key]
        public string TConst { get; set; }
        public string? ParentTConst { get; set; }
        public int? SeasonNumber { get; set; }
        public int? EpisodeNumber { get; set; }
    }
}