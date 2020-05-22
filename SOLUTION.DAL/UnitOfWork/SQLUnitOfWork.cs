using SOLUTION.DAL.Interfaces;
using SOLUTION.DAL.Interfaces.SQLInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLUTION.DAL.UnitOfWork
{
    public class SQLUnitOfWork : ISQLUnitOfWork
    {
        private readonly ISQLRoleRepository _sqlRoleRepository;

        public SQLUnitOfWork(ISQLRoleRepository sqlRoleRepository)
        {
            _sqlRoleRepository = sqlRoleRepository;
        }

        public ISQLRoleRepository SQLRoleRepository
        {
            get
            {
                return _sqlRoleRepository;
            }
        }


        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
