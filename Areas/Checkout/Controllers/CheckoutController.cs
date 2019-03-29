using Microsoft.AspNetCore.Mvc;

namespace genericRepoDemo.Areas.Billing.Controllers
{
    [Area("Checkout")]
    public class CheckoutController : Controller
    {
        public IActionResult Index(){

            return View();
        }
    }
}