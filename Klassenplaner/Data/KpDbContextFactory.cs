using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace Klassenplaner.Data
{


    public class KpDbContextFactory : IDesignTimeDbContextFactory<KpDbContext>
    {
        public KpDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<KpDbContext>();

            var configbuilder = new ConfigurationBuilder();
            var configuration = configbuilder
                                    .AddUserSecrets<Startup>()
                                    .Build();



            
            var connectionString = configuration.GetConnectionString("Default");
            optionsBuilder.UseSqlServer(connectionString);
            return new KpDbContext(optionsBuilder.Options);
        }
    }
}