using BookAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
            Database.EnsureCreated();
        }

        DbSet<Book> Books { get; set; }
    }
}
