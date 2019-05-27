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
            var cats = new[] { "Пиле", "Муле" }.ToList();

            Note note1 = new Note()
            {
                Id = 100,
                Content = "Class created content",
                CreationTime = DateTime.Now,
                AuthorId = 11,
                Author = new User()
                {
                    Id = 11,
                    Username = "Страхил",

                }
            };

            Note note2 = new Note()
            {
                Id = 101,
                Content = "Class created content2",
                CreationTime = DateTime.Now,
                AuthorId = 12,
                Author = new User()
                {
                    Id = 12,
                    Username = "Панакуди",

                }
            };

            List<Note> notes2 = new List<Note>();
            notes2.Add(note1);
            notes2.Add(note2);




            return this.View(notes2);
        }
    }
}
