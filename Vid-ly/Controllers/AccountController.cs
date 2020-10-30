using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Vid_ly.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index(int Id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Upload(int Id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(int Id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            return View();
        }        

    }
}