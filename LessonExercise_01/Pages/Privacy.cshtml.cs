using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace LessonExercise_01.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public string DayOfTheWeekInSwedish { get; set; }
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            DayOfTheWeekInSwedish = DateTime.Now.ToString();

            var svenska = new CultureInfo("sv-SE");
            DayOfTheWeekInSwedish = DateTime.Now.ToString("dddd", svenska);
        }
    }
}
