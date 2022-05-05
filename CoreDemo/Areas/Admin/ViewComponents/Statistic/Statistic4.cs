using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4:ViewComponent
    {
        Context c=new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1=c.Admins.Where(x=>x.AdminId==1).Select(x=>x.Name).FirstOrDefault();
            ViewBag.v2=c.Admins.Where(x=>x.AdminId==1).Select(c=>c.ImageURL).FirstOrDefault();
            ViewBag.v3=c.Admins.Where(x=>x.AdminId==1).Select(c=>c.ShortDescription).FirstOrDefault();
            return View();
        }
    }
}
