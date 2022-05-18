using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zambia_Police_Service_Repository.DALL.Interfaces;

namespace Zambia_Police_Service.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IService _service;

        public UserController(IService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult AddUser(PoliceUsers users)
        {
            var user = _service.AddUser(users);

            return Ok(user);
        }
    }
}
