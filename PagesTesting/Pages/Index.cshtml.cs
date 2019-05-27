using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PagesTesting.Pages
{
    public class IndexModel : PageModel
    {
        public string[] Cats;


        public void OnGet()
        {
            Cats = new[] {"Боби", "Пешо", "Пильо"};
        }
    }
}
