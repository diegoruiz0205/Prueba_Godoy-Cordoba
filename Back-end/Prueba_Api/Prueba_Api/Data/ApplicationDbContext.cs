using Microsoft.EntityFrameworkCore;
using Prueba_Api.Entities;

namespace Prueba_Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){
        }
        public DbSet<CatFactEntity> CatFacts { get; set; }

    }
}
