using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica2
{
    public class ApplicationDbContext : DbContext
    {
        [Obsolete]
#pragma warning disable CS0809 // Obsolete member overrides non-obsolete member
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#pragma warning restore CS0809 // Obsolete member overrides non-obsolete member
        {
            //.UseLoggerFactory(new LoggerFactory().AddConsole((category, level) => level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true))
            optionsBuilder.UseSqlServer("Server=localhost;Database=Usuarios;User Id=sa;Password=reallyStrongPwd123")
            //optionsBuilder.UseSqlServer("Server=financeappdb.database.windows.net;Database=FinanceApp;User Id=homework;Password=3rMoLtZm20mT")
               .EnableSensitiveDataLogging(true).UseLoggerFactory(new LoggerFactory().AddConsole((category, level) => level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true));
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ingreso> Ingresos { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
    }
}