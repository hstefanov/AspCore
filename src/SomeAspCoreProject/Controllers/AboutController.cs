using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using SomeAspCoreProject.Entities;
using SomeAspCoreProject.Services;
using SomeAspCoreProject.ViewModels;

namespace SomeAspCoreProject.Controllers
{
    [Route("[controller]")]
    public class AboutController : Controller
    {
        private IData _data;
        private IGreeter _greeter;

        public AboutController(IData data, IGreeter greeter)
        {
            _data = data;
            _greeter = greeter;
        }

        [Route("[action]")]
        public IActionResult Index()
        {

            var model = new DataViewModel();

            model.Data = _data.GetAll();
            model.CurrentGreeting = _greeter.GetGreeting();

            return View(model);
        }

        [Route("[action]")]
        public IActionResult Details(int id)
        {
            return Content(id.ToString());
        }
    }
}
