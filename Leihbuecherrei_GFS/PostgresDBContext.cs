using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leihbuecherrei_GFS
{
    //sets up Entity Framework Core to work with a Postgres Database
    public class PostgresDBContext : DbContext
    {
        //tells EF Core which classes should be mapped to the database
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowEntry> BorrowEntries { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //sets up the connection to the database
            //this connection string probably needs to be changed to work with the databese on your machine if you didn't use the same name, password etc as I did
            optionsBuilder.UseNpgsql(connectionString: "Host=localhost;Database=Leihbuecherei_GFS;Username=postgres;Password=Nilsi#2006;Timeout=10;SslMode=Prefer;Include Error Detail=True");
            
            //Activates Lazy Loading which will load realated entitys only when they are accessed
            optionsBuilder.UseLazyLoadingProxies();

            //Logs all SQL commands to the Debug Console
            optionsBuilder.LogTo(message => Debug.WriteLine(message)).EnableSensitiveDataLogging();

            base.OnConfiguring(optionsBuilder);
        }
    }
}
