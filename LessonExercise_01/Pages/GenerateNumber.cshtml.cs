using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LessonExercise_01.Pages
{
    public class GenerateNumberModel : PageModel
    {
        private static Random randomNum = new Random();
        public int MyRandomNumber { get; set; }

        public string Tid { get; set; }
        public void OnGet()
        {
            Tid = DateTime.Now.ToString("HH:mm");

            MyRandomNumber = randomNum.Next(0, 300000);
        }
    }
}
