using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PagesTesting.Pages
{
    public class CatsModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Hello to cats page!";
        }
    }
}