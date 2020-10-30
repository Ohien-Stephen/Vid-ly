using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Vid_ly.Controllers
{
    public class ChannelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("channel/{id:int}")]
        public IActionResult Channel(int Id)
        {
            return View(Id);
        }

        [HttpGet]
        public IActionResult Create(int Id)
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