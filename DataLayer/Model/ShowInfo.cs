using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class ShowInfo
    {
        [Key]
        public string TConst { get; set; }
        public string Type { get; set; }
        public string PrimaryTitle { get; set; }
        public string OriginalTitle { get; set; }
        public bool IsAduldt { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
        public int? RunTime { get; set; }
    }
}
