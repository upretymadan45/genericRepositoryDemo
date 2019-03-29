using Microsoft.AspNetCore.Mvc;

namespace genericRepoDemo.Areas.Billing.Controllers
{
    [Area("Billing")]
    public class BillingController : Controller
    {
        public IActionResult Index(){

            return View();
        }
    }
}