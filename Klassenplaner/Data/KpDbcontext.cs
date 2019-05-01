using Klassenplaner.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Klassenplaner.Data
{
    public class KpDbContext : DbContext
    {
        public KpDbContext(DbContextOptions<KpDbContext> options) : base(options)
        {

        }

        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Timeslot> Timeslots { get; set; }
        public DbSet<Room> Rooms { get; set; }
        //public DbSet<Student> Students { get; set; }

    }
}
