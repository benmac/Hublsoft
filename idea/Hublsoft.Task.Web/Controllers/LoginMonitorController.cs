using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hublsoft.Web.Infrastructure;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Hublsoft.Web.Controllers
{
    public class LoginMonitorController : Controller
    {
        private readonly LoginService _service;

        public LoginMonitorController(LoginService service)
        {
            this._service = service;
        }

        public IActionResult Index()
        {
            var preferJSON = Request.Headers["Accepts"] == "application/json";
            return preferJSON ? IndexAsJSON() : View();
        }

        private IActionResult IndexAsJSON() => base.Json(_service.GetLoginsForAllUsers());

        [HttpPost]
        public IActionResult Index(string userId, int? count, int granularity)
        {
            var model = new Hublsoft.Web.Models.LoginMonitorVM() { ResultCount = _service.GetCountFilteredLoginsForUser(userId, count, (DataHelper.TimeSpanGranularity)granularity) };
            return View(model);
        }
    }
}
