using System;

namespace WepAppMVC.Models
{
    public class Functionality
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Decoration { get; set; }
        public int ParentId { get; set; }
        public int Priority { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateUser { get; set; }
    }
}
