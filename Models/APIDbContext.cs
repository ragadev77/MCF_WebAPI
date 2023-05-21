using MCFWebAPI.DBClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace MCFWebAPI.Models
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions options) : base(options)
        {
           //Database.EnsureCreated();
        }
        
        public DbSet<BPKB> BPKBs { get; set; }
        public DbSet<Location> Locations { get; set; }

    }
}
