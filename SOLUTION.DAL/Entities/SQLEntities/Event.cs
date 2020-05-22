using SOLUTION.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLUTION.DAL.Entities.SQLEntities
{
    public class Event: IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string ImageLink { get; set; }
        public Category Category { get; set; } 
        public List<HashTag> hashTags { get; set; }
        public List<Comment> comments { get; set; }
    }
}
