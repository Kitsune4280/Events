using SOLUTION.DAL.Entities.SQLEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLUTION.DAL.Interfaces.SQLInterfaces.Services
{
    public interface ISQLRoleService
    {
        int AddRole(Role role);

        Role GetRoleById(int id);
        void UpdateRole(Role role);
        void DeleteRole(int id);
        IEnumerable<Role> GetAllRoles();
    }
}
