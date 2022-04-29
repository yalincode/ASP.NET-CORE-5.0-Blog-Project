using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    UserName = "Yalın",

                },
                new UserComment
                {
                    Id = 2,
                    UserName = "mesut",

                },
                new UserComment
                {
                    Id = 3,
                    UserName = "merve",

                },
            };
                
                return View(commentValues);
        }
    }
}
