using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hublsoft.Web.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Hublsoft.Web.Controllers
{
    public class LoginMonitorController : Controller
    {
        private readonly LoginService service;

        public LoginMonitorController(LoginService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            var model = service.GetLoginsForAllUsers();
            return View(model);
        }
    }
}
