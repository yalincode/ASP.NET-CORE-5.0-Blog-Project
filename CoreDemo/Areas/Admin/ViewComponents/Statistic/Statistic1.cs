using BusinessLayer.Concrete;
using DataAccessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c=new Context();
        public IViewComponentResult Invoke()
        {

            ViewBag.v1=bm.GetList().Count();
            ViewBag.v2=c.Contacts.Count();
            ViewBag.v3=c.Comments.Count();

            string api = "e83b3c4c08285bf87b99f9bbc0abe3f0";//api yi buraya yaz
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&units=metric&appid=" + api;
            XDocument document=XDocument.Load(connection);
            ViewBag.v4=document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
