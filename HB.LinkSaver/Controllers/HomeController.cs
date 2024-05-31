using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HB.LinkSaver.Controllers
{
    public class HomeController:Controller
    {

        public IActionResult Index()
        {
            return Json("test deneme bir");
        }
        public IActionResult CustomAction()
        {
           return Json("denemeeee");
        }
    }
}
