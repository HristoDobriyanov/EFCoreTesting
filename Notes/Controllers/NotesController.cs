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
        public NotesController(NotesDbContext context)
        {
            this.DbContext = context;
        }

        public NotesDbContext DbContext { get; set; }

        public IActionResult All()
        {
           
            var notes = this.DbContext.Notes.ToList();

            return this.View(notes);
        }

        [HttpGet]
        public IActionResult New() => this.View();

        [HttpPost]
        public IActionResult New(string content)
        {
            Note note = new Note()
            {
                AuthorId = 2,
                Content = content,
                CreationTime = DateTime.Now
            };

            this.DbContext.Notes.Add(note);
            this.DbContext.SaveChanges();

            return this.RedirectToAction("All", "Notes");
        }
    }
}
