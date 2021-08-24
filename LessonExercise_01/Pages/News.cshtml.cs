using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LessonExercise_01.Pages
{
    public class NewsModel : PageModel
    {
        public List<NewsItemList> Items { get; set; }

        public class NewsItemList
        {
            public string Title { get; set; }
            public string Desc { get; set; }
        }
        public void OnGet()
        {
            Items = new List<NewsItemList>
            {
                new NewsItemList{Desc = "Joe Biden hits the dab", Title = "Joe Biden did what?"},
                new NewsItemList{Desc = "fghgghjfgjyj", Title = "123123123123"},
                new NewsItemList{Desc = "Hehe", Title = "Haha"}
            };
        }   
    }
}
