using Microsoft.AspNetCore.Mvc;
using ProjectWeb.Data;
using ProjectWeb.Models.Domain;
using ProjectWeb.Models.ViewModels;

namespace ProjectWeb.Controllers
{
    public class AdminTagsController : Controller

    {
        private ProjectWebDBContext _dbContext;
        public AdminTagsController(ProjectWebDBContext projectWebDBContext)
        {
            _dbContext = projectWebDBContext;
            
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest) 
        {
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };

            _dbContext.Tags.Add(tag);
            _dbContext.SaveChanges();
            
            return View("Add");
        }
    }
}
