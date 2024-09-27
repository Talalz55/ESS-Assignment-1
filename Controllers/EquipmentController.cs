using Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    public class EquipmentController : Controller
    {
        [HttpGet]
        public IActionResult RequestForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RequestForm(EquipmentRequest request)
        {
            if (ModelState.IsValid)
            {
                EquipmentRequestRepository.AddRequest(request);
                return RedirectToAction("Confirmation", new {id = request.Id});
            }
            return View(request);
        }
        [HttpGet]
        public IActionResult AllEquipment()
        {
            var equipmentList = EquipmentRepository.GetAllEquipment();
            return View(equipmentList);
        }
        [HttpGet]
        public IActionResult AvailableEquipment()
        {
            var availableEquipmentList = EquipmentRepository.GetAvailableEquipment();
            return View(availableEquipmentList);
        }
        [HttpGet]
        public IActionResult Confirmation(int id)
        {
            var request = EquipmentRequestRepository.GetAllRequests().FirstOrDefault(request => request.Id == id);
            if (request != null)
            {
                return View(request);
            }
            return RedirectToAction("RequestForm");
        }
    }
}
