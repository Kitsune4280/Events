using SOLUTION.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLUTION.DAL.Entities.SQLEntities
{
    public class Member: IEntity<int>
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public bool Suspended { get; set; }
        public List<Role> Roles { get; set; }
        public List<Member> FollowList { get; set; } 
        public List<Event> SubscribedEvents { get; set; }
    }
}
