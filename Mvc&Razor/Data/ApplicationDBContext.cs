using Microsoft.EntityFrameworkCore;
using Mvc_Razor.Models;

namespace Mvc_Razor.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) 
            : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<CustomerBookList> CustomerBookLists { get; set; }
    }
}
