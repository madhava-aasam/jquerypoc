using Microsoft.AspNetCore.Mvc;
//using System.Web.Mvc;

namespace jquerypoc.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetMessage()
        {
            var message = new { Text = "Hello from sample page" };
            return new JsonResult(message);
        }
    }
}
