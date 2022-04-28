using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Entity1.Models
{
    public class SeriesDBContext : DbContext
    {
        public SeriesDBContext()
        {

        }
        public SeriesDBContext(DbContextOptions<SeriesDBContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-VPJUN21;Initial Catalog=AdventureWorks2019;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        }
        public virtual DbSet<Series> Series { get; set; }



    }
}

