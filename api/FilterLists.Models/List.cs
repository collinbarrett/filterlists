﻿namespace FilterLists.Models
{
    public class List : BaseEntity
    {
        public string Description { get; set; }
        public string DescriptionSourceUrl { get; set; }
        public string DonateUrl { get; set; }
        public string Email { get; set; }
        public string ForumUrl { get; set; }
        public string HomeUrl { get; set; }
        public string IssuesUrl { get; set; }
        public string Name { get; set; }
        public string ViewUrl { get; set; }
    }
}