using Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    public class Admin : Controller
    {
        [HttpGet]
        public IActionResult Requests()
        {
            var requestsList = EquipmentRequestRepository.GetAllRequests();
            return View(requestsList);
        }
    }
}
