using SOLUTION.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLUTION.DAL.Entities.SQLEntities
{
    public class Events_Hashtags : IEntity<int>
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int HashtagId { get; set; }
    }
}
