using SOLUTION.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Linq;
using System.Reflection;
using System.Data;

namespace SOLUTION.DAL.Repositories
{
    public class GenericRepository<TEntity, TId> : IGenericRepository<TEntity, TId> where TEntity : IEntity<TId>
    {
        protected IConnectionFactory _connectionFactory;
        private readonly string _TableName;

        public GenericRepository(IConnectionFactory connectionFactory, string tableName)
        {
            _connectionFactory = connectionFactory;
            _TableName = tableName;
        }

        private IEnumerable<string> GetColumns()
        {
            return typeof(TEntity)
                .GetProperties()
                .Where(p => p.Name != "Id" && !p.PropertyType.GetTypeInfo().IsGenericType)
                .Select(p => p.Name);
        }

        public int Create(TEntity entity)
        {
            var columns = GetColumns();
            var columnsString = string.Join(", ", columns);
            var propertiesString = string.Join(", ", columns.Select(c => "@" + c));

            var query = "SP_InsertRecord";
            using(var db = _connectionFactory.GetConnection)
            {
                var Statement = db.Query<string>(
                    sql: query,
                    param: new { P_tableName = _TableName, P_columnString = columnsString, P_propertiesString = propertiesString },
                    commandType: CommandType.StoredProcedure
                    ).FirstOrDefault();

                var InsertedEntityId = db.Execute(
                    sql: Statement,
                    param: entity,
                    commandType: CommandType.Text);
                return InsertedEntityId;
            }
        }

        public void Delete(TId id)
        {
            using(var db = _connectionFactory.GetConnection)
            {
                var query = "SP_DeleteRecord";
                var result = db.Execute(
                    sql: query,
                    param: new { P_tableName = _TableName, P_Id = id },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public TEntity Get(TId id)
        {
            var query = "SP_GetRecordById";
            using(var db = _connectionFactory.GetConnection)
            {
                return db.Query<TEntity>(
                    sql: query,
                    param: new { P_tableName = _TableName, P_Id = id },
                    commandType: CommandType.StoredProcedure
                    ).FirstOrDefault();
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            var query = "SP_GetAllRecords";
            using(var db = _connectionFactory.GetConnection)
            {
                return db.Query<TEntity>(
                    sql: query,
                    param: new { P_tableName = _TableName },
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public void Update(TEntity entity)
        {
            var columns = GetColumns();   
            var columnsString = string.Join(", ", columns.Select(c => $"{c} = @{c}"));
            using(var db = _connectionFactory.GetConnection)
            {
                var query = "SP_UpdateRecord";
                var updateStatement = db.Query<string>(
                    sql: query,
                    param: new { P_tableName = _TableName, P_columnsString = columnsString, P_Id = entity.Id },
                    commandType: CommandType.StoredProcedure
                    ).FirstOrDefault();

                db.Execute(
                    sql: updateStatement,
                    param: entity,
                    commandType: CommandType.Text);
            }
        }
    }
}
