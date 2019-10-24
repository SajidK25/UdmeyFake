using System;
using Microsoft.EntityFrameworkCore;
using UdemyAPI.Core;

namespace UdemyAPI.Library
{
    public class UdmeyContext : DbContext
    {
        private string _connection;
        private string _migrationAssemblyName;
        public UdmeyContext(string connection, string migrationAssemblyName)
        {
            _connection = connection;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connection, m => m.MigrationsAssembly(_migrationAssemblyName));
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tag>()
                .ToTable("Tags");
            modelBuilder.Entity<tag>()
                .HasMany(a => a.Courses)
                .WithOne(c => c.Author);

            modelBuilder.Entity<CourseTag>()
               .HasOne(ct => ct.Course)
               .WithMany(c => c.Tags)
               .HasForeignKey(ct => ct.CourseId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<tag> Authors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<CourseTag> CourseTags { get; set; }
    }
}
