using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Texter.Models;

namespace Texter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetMessages()
        {
            var allMessages = Message.GetMessages();
            return View(allMessages);
        }

        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message newMessage)
        {
            newMessage.Send();
            return RedirectToAction("Index");
        }

        public IActionResult SmsResponseGet(Response response)
        {
            return View(response);
        }

        [HttpPost]
        public IActionResult SmsResponse(Response response)
        {
            return RedirectToAction("SmsResponseGet", response);
        }
    }
}
