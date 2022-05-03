using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        
        public IActionResult InBox()
        {
            int id = 2;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }

        [HttpGet]
        public IActionResult MessageDetail(int id)
        {
            var value = mm.GetById(id);
            return View(value);
        }
    }
}
