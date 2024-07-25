using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leihbuecherrei_GFS
{
    public class PostgresDBContext : DbContext
    {
        public DbSet<Reader> Readers { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseNpgsql(connectionString: "Host=localhost;Database=Leihbuecherei_GFS;Username=postgres;Password=Nilsi#2006;Timeout=10;SslMode=Prefer");

            optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, Microsoft.Extensions.Logging.LogLevel.Information);

            base.OnConfiguring( optionsBuilder );
        }
    }
}
