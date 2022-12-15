using System;
namespace WebServer.Models
{
    public class ShowInfoCreateModel
    {
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

