using SOLUTION.DAL.Entities.SQLEntities;
using SOLUTION.DAL.Interfaces;
using SOLUTION.DAL.Interfaces.SQLInterfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace SOLUTION.DAL.Repositories.SQLRepositories
{
    public class SQLRoleRepository: GenericRepository<Role, int>, ISQLRoleRepository
    {
        private static readonly string _tableName = "Roles";
        
        public SQLRoleRepository(IConnectionFactory connectionFactory): base(connectionFactory, _tableName)
        {
            connectionFactory.SetConnection(ConfigurationManager.ConnectionStrings["DB_Events"].ConnectionString);
        }
    }
}
