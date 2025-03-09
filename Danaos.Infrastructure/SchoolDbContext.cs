using System;
using Danaos.Domain.Domain.Grades;
using Danaos.Domain.Domain.Student;
using Microsoft.EntityFrameworkCore;

namespace Danaos.Infrastructure;

public class SchoolDbContext : DbContext
{
    public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
     : base(options){ }

    public DbSet<Student> Students { get; set; }
    public DbSet<Grade> Grades { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Grade>().HasKey(g => new { g.Student_Id, g.Course_Id });

            modelBuilder.Entity<Grade>()
                .HasOne(g => g.Student)
                .WithMany(s => s.Grades)
                .HasForeignKey(g => g.Student_Id);

    }
}
