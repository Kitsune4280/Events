using SOLUTION.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLUTION.DAL.Entities.SQLEntities
{
    public class Members_Followers : IEntity<int>
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int FollowedMemberId { get; set; }
    }
}
