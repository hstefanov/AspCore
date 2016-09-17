using Microsoft.AspNetCore.Mvc;

namespace SomeAspCoreProject.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "controller return";
        }
    }
}
