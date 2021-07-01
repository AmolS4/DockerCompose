using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using servicetwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servicetwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        PatientsDb database;
        public PatientController()
        {
            database = new PatientsDb();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(database);
        }
    }
}
