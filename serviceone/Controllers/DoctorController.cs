using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using serviceone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serviceone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        DoctorDb database;

        public DoctorController()
        {
            database = new DoctorDb();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(database);
        }
    }
}
