using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BID_E.Models;


namespace BID_E.Controllers
{
    public class GraphsController : Controller
    {
        private readonly ILogger<GraphsController> _logger;

        public GraphsController(ILogger<GraphsController> logger)
        {
            _logger = logger;
        }

        // GET: /<controller>/
        public IActionResult Landing()
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
