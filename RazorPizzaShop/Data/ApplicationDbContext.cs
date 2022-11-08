using Microsoft.EntityFrameworkCore;
using RazorPizzaShop.Models;

namespace RazorPizzaShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> Orders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base()
        {

        }
    }
}
