using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using SomeAspCoreProject.Models;
using SomeAspCoreProject.Services;

namespace SomeAspCoreProject.Controllers
{
    [Route("[controller]")]
    public class AboutController : Controller
    {
        private IData _data;

        public AboutController(IData data)
        {
            _data = data;
        }

        [Route("[action]")]
        public IActionResult Index()
        {
            var model = _data.GetAll();

            return View(model);
        }
    }
}
