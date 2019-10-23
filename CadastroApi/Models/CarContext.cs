using Microsoft.EntityFrameworkCore;
using CadastroApi.Models;

namespace CadastroApi.Models
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<CadastroApi.Models.Car> Car { get; set; }
    }
}