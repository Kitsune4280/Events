using SOLUTION.DAL.Entities.SQLEntities;
using SOLUTION.DAL.Interfaces;
using SOLUTION.DAL.Interfaces.SQLInterfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLUTION.DAL.Services.SQLServices
{
    public class SQLRoleService : ISQLRoleService
    {
        ISQLUnitOfWork _unitOfWork;

        public SQLRoleService(ISQLUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        //TODO
        public int AddRole(Role role)
        {
            return _unitOfWork.SQLRoleRepository.Create(role);
        }

        public void DeleteRole(int id)
        {
            _unitOfWork.SQLRoleRepository.Delete(id);
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return _unitOfWork.SQLRoleRepository.GetAll();
        }

        public Role GetRoleById(int id)
        {
            return _unitOfWork.SQLRoleRepository.Get(id);
        }

        public void UpdateRole(Role role)
        {
            _unitOfWork.SQLRoleRepository.Update(role);
        }
    }
}
