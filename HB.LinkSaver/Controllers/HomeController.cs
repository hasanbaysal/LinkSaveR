using HB.LinkSaver.DataAcces;
using Microsoft.AspNetCore.Mvc;

namespace HB.LinkSaver.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return Json("test deneme bir");
        }


        [HttpGet("GetAllCategoryNames")]
        public IActionResult GetAllCategoryNames()
        {

            var data = CategoryManager.GetAllCategoryNames();
            return Json(data);
        }
        [HttpGet("GetCategoryByNames/{name}")]
        public IActionResult GetCategoryByNames(string name)
        {
            return Json(CategoryManager.GetAllCateriesByGroupName(name));
        }

        [HttpPost]
        public IActionResult SaveData([FromBody] AddDto dto)
        {

           

            var link = new Link()
            {
                Categories = dto.Categories,
                Content = dto.Content,
                Description = dto.Description,
                Header = dto.Header
            };

          var result =   LinkManager.Add(link, true);
          


          

          
            if (result)
            {
                Program.MainFrm.SearchByFilters();
                return Ok("ok");
            }
            else
                return BadRequest("error");
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
