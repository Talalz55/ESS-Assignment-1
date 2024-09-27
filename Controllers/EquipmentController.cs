using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    public class EquipmentController : Controller
    {
        public IActionResult RequestForm()
        {
            return View();
        }
    }
}
