using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leihbuecherrei_GFS
{
    public class PostgresDBContext : DbContext
    {
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowEntry> BorrowEntries { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseNpgsql(connectionString: "Host=localhost;Database=Leihbuecherei_GFS;Username=postgres;Password=Nilsi#2006;Timeout=10;SslMode=Prefer;Include Error Detail=True");

            optionsBuilder.LogTo(message => Debug.WriteLine(message)).EnableSensitiveDataLogging();

            base.OnConfiguring( optionsBuilder );
        }
    }
}
