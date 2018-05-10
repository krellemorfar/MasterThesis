using DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseService
{
    class FootballContext : DbContext
    {
        public DbSet<Fixture> Fixtures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=mysql3.gigahost.dk;database=krellemorfar_masterthesis;uid=krellemorfar;pwd=Fckfck123");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
