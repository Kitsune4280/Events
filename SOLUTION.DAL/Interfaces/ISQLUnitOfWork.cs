using SOLUTION.DAL.Interfaces.SQLInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLUTION.DAL.Interfaces
{
    public interface ISQLUnitOfWork
    {
        ISQLRoleRepository SQLRoleRepository { get; }

        void Complete();
    }
}
