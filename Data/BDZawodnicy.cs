using Microsoft.EntityFrameworkCore;
using Domain;

namespace Data
{
    public class BDZawodnicy : DbContext
    {
        public DbSet<Plywak> Plywacy { get; set; }

        public BDZawodnicy(DbContextOptions<BDZawodnicy> options) : base(options)
        {
        }
    }
}