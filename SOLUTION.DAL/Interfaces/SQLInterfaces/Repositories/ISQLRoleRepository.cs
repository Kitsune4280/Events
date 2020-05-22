using SOLUTION.DAL.Entities.SQLEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLUTION.DAL.Interfaces.SQLInterfaces.Repositories
{
    public interface ISQLRoleRepository: IGenericRepository<Role, int>
    {
    }
}
