using Microsoft.EntityFrameworkCore;
using Videoteka.Models;

namespace Videoteka.Data
{
    public class VideotekaaContext : DbContext
    {
        public VideotekaaContext(DbContextOptions<VideotekaaContext> options)
            : base(options)
        {
        }

        public DbSet<Film> Film { get; set; }
    }
}
