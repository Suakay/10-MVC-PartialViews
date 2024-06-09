using Microsoft.AspNetCore.Mvc;

namespace _10_MVC_PartialViews.Controllers
{
    public class SampleController : Controller
    {
        public PartialViewResult Sample()
        {
            return PartialView("_SamplePartial");//çağırmak için yazdık
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
