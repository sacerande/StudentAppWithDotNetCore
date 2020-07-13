
namespace StudentAppDotNetCore.Database
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    public partial class dbStudent : DbContext
    {
        public dbStudent()
            : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=dbStudent;Trusted_Connection=True;user id=sa;password=221184");
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<student> student { get; set; }
        public virtual DbSet<subjects> subjects { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<student>()
        //        .HasMany(e => e.subjects)
        //        .WithOptional(e => e.student)
        //        .HasForeignKey(e => e.studid);
        //}
    }
}
