﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HB.LinkSaver.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return Json("test deneme bir");
        }
        public IActionResult CustomAction()
        {

            var data = CategoryManager.GetAll();
            return Json(data);
        }

        [HttpPost]
        public IActionResult SaveData([FromBody] AddDto dto)
        {

            //var txt = str.ToString();   

            var link = new Link()
            {
                Categories = dto.Categories,
                Content = dto.Content,
                Description = dto.Description,
                Header = dto.Header
            };

            LinkManager.Add(link);
            Program.MainFrm.LoadDgw();
            return Ok();
        }


    }


    public class AddDto
    {
        public string? Description { get; set; }
        public string? Header { get; set; }
        public string? Content { get; set; }
        public List<string> Categories { get; set; }
    }
}