using Microsoft.AspNetCore.Mvc;

namespace genericRepoDemo.Areas.Billing.Controllers
{
    [Area("Inventory")]
    public class InventoryController : Controller
    {
        public IActionResult Index(){

            return View();
        }
    }
}