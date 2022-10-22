using CRUDahm.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDahm.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }
        public DbSet<BookList> BookList { get; set; }   
    }
}
