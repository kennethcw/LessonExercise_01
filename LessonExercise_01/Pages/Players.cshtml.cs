using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LessonExercise_01.Pages
{
    public class PlayersModel : PageModel
    {
        public List<string> Players { get; set; }
        public void OnGet()
        {
            Players = new List<string>
            {
                "Isak Petersson",
                "Kenneth Chew",
                "Crille Lindberg",
                "Random Name",
                "Name 222222"
            };
        }
    }
}
