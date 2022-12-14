using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class ShowInfo
    {
        public string ShowInfoId { get; set; }
        public string Type { get; set; }
        public string PrimaryTitle { get; set; }
        public string OriginalTitle { get; set; }
        public bool IsAdult { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
        public int? RunTime { get; set; }
        public string? Poster { get; set; }

    }

}
