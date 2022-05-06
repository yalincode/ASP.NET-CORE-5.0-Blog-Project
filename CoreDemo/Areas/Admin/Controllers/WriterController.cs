using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            var jsonWriters=JsonConvert.SerializeObject(writers);
            return Json(jsonWriters);
        }

        public IActionResult GetWriterByID(int writerid)
        {
            var findWriter=writers.FirstOrDefault(x=>x.Id== writerid);
            var jsonWriter = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriter);
        }

        [HttpPost]
        public IActionResult AddWriter(WriterClass w)
        {
            writers.Add(w);
            var jsonWriters = JsonConvert.SerializeObject(w);
            return Json(jsonWriters);
        }

        [HttpPost]
        public IActionResult DeleteWriter(int id)
        {
            var writer =writers.FirstOrDefault(x=>x.Id== id);
            writers.Remove(writer);
            var jsonWriters = JsonConvert.SerializeObject(writer);
            return Json(jsonWriters);
        }

        [HttpPost]
        public IActionResult UpdateWriter(WriterClass w)
        {
            var writer = writers.FirstOrDefault(x=>x.Id== w.Id);
            writer.Name = w.Name;
            var jsonWriters = JsonConvert.SerializeObject(writer);
            return Json(jsonWriters);
        }


        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                Id =1,
                Name="Ayşe"
            },
            new WriterClass
            {
                Id =2,
                Name="Yalın"
            },
            new WriterClass
            {
                Id =3,
                Name="Reha"
            },
        };
    }

}
