using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNottification:ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
