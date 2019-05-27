using System;

namespace Notes.Models
{
    public class Note
    {
        public string Id { get; set; }

        public string Content { get; set; }

        public DateTime CreationTime { get; set; }

        public int AuthorId { get; set; }

        public User Author { get; set; }

    }
}
