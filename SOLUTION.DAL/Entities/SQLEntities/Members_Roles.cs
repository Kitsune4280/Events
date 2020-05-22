using SOLUTION.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLUTION.DAL.Entities.SQLEntities
{
    public class Members_Roles : IEntity<int>
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int RoleId { get; set; }
    }
}
