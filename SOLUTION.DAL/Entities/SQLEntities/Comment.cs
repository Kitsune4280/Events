using SOLUTION.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLUTION.DAL.Entities.SQLEntities
{
    public class Comment : IEntity<int>
    {
        public int Id { get; set ; }
        public DateTime PostedAt { get; set; }
        public string Content { get; set; }
        public Member Member { get; set; }
        public Event Event { get; set; }
    }
}
