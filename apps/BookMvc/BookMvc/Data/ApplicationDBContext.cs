using Microsoft.EntityFrameworkCore;
using BookMvc.Models;

namespace BookMvc.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }

    }
}
