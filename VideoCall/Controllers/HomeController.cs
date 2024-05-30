using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace VideoCall.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect($"/{Guid.NewGuid()}");
        }

        [HttpGet("/{roomId}")]
        public IActionResult Room(string roomId)
        {
            ViewBag.RoomId = roomId;
            return View();
        }
    }
}
