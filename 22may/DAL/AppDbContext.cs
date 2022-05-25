using _22may.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace _22may.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Portofolio> Portofolios { get; set; }
    }
}
