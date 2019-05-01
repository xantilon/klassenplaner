using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System.Linq;
namespace Klassenplaner.Data.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new KpDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<KpDbContext>>()))
            {
                context.SaveChanges();

                // Look for any schools.
                if (context.Schools.Any())
                {
                    return;   // DB has been seeded
                }

                var schools = new[] {
                    new School
                    {
                        Name = "Karl-Rehbein-Schule",
                        City = "Hanau",
                        Country = eCountry.Deutschland
                    }
                };

                context.Schools.AddRange(schools);
                context.SaveChanges();

                var classes = new[] {
                    new Class
                    {
                        SchoolId = schools[0].Id,
                        Year = 5,
                        Group = (byte)'d'
                    }
                };
                context.Classes.AddRange(classes);
                context.SaveChanges();

                var timeslots = new[] {
                    new Timeslot {
                        Order = 0,
                        Start = new TimeSpan(7, 55, 0),
                        End = new TimeSpan(8, 40, 0),
                        ClassId = classes[0].Id
                    },
                    new Timeslot
                    {
                        Order = 1,
                        Start = new TimeSpan(8, 45, 0),
                        End = new TimeSpan(9, 30, 0),
                        ClassId = classes[0].Id
                    },
                    new Timeslot
                    {
                        Order = 2,
                        Start = new TimeSpan(9, 30, 0),
                        End = new TimeSpan(9, 45, 0),
                        ClassId = classes[0].Id
                    },
                    new Timeslot
                    {
                        Order = 3,
                        Start = new TimeSpan(9, 45, 0),
                        End = new TimeSpan(10, 30, 0),
                        ClassId = classes[0].Id
                    }

                };
                context.Timeslots.AddRange(timeslots);
                context.SaveChanges();
            }
        }
    }
}
