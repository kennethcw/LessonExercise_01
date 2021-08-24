using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LessonExercise_01.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace LessonExercise_01.Pages
{
    public class KrisInfoListaModel : PageModel
    {
        private readonly IKrisInfoService _krisInfoService;

        public KrisInfoListaModel(IKrisInfoService krisInfoService)
        {
            _krisInfoService = krisInfoService;
        }

        public List<NewsListItem> Items { get; set; }

        public class NewsListItem
        {
            public string Id { get; set; }
            public string Title { get; set; }
        }
        public void OnGet()
        {
            Items = _krisInfoService.GetAllKrisInformation().Select(r => new NewsListItem
            {
                Id = r.Id,
                Title = r.Title
            }).ToList();

        }
    }
}
