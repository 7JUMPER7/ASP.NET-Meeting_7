using Meeting_7.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meeting_7.Models
{
    public class Quest : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Difficulty { get; set; }
        public string Size { get; set; }
        public int Time { get; set; }
        public string LongDescriptionHeader { get; set; }
        public string LongDescription { get; set; }
    }
}