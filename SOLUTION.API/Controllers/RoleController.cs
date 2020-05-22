using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOLUTION.DAL.Entities.SQLEntities;
using SOLUTION.DAL.Services.SQLServices;

namespace SOLUTION.API.Controllers
{
    [ApiController]
    [Route("controller")]
    public class RoleController : ControllerBase
    {
        SQLRoleService service;

        public RoleController()
        {
        }

        public RoleController(SQLRoleService service)
        {
            this.service = service;
        }

        [Route("list")]
        [HttpGet]
        public IEnumerable<Role> getAllRoles()
        {
            Console.WriteLine("getAllRoles called");
            return service.GetAllRoles();
        }
    }
}