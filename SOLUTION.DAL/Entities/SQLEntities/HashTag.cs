using SOLUTION.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLUTION.DAL.Entities.SQLEntities
{
    public class HashTag: IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
