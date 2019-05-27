using Microsoft.EntityFrameworkCore;
using Notes.Models;

namespace Notes.Data
{
    public class NotesDbContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-R4OGD90\SQLEXPRESS;
                                                            Database=NotesAppASPNetCore;
                                                            Integrated Security=True");
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
