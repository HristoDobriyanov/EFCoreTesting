using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Notes.Data;
using Notes.Models;

namespace Notes.Controllers
{
    public class NotesController : Controller
    {
        public IActionResult All()
        {
            var context = new NotesDbContext();
            var notes = context.Notes.ToList();

            return this.View(notes);
        }
    }
}
