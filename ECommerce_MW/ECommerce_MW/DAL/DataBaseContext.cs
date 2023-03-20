using ECommerce_MW.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_MW.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {
            
        }

        public DbSet<Country> Countries { get; set; }
    }
}
