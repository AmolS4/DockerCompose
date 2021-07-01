using doctorpatientclient.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace doctorpatientclient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();

            ////var result = await client.GetStringAsync("http://servhost/api/Test");
            var result = await client.GetStringAsync(" http://localhost:30717/api/doctor");
            //ViewBag.Response = result;


            return View();
        }

        public async Task<IActionResult> Doctor()
        {
            HttpClient client = new HttpClient();

            //var result = await client.GetStringAsync("http://servhost/api/Test");
            var result = await client.GetStringAsync(" http://localhost:30717/api/doctor");
            ViewBag.Response = result;


            return View();
        }
        public async Task<IActionResult> Patient()
        {
            HttpClient client = new HttpClient();

            //var result = await client.GetStringAsync("http://servhost/api/Test");
            var result = await client.GetStringAsync("http://localhost:40206/api/patient");
            ViewBag.Response = result;


            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
