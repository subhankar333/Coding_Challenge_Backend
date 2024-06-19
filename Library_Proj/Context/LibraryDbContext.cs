
using Coding_Challenge_Backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Coding_Challenge_Backend.Context
{
    public class LibraryDbContext:DbContext
    {
        public LibraryDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Library_Proj.Models.User> Users { get; set; }

    }
}
