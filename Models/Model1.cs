namespace Carswebapp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Table_1> Table_1 { get; set; }
        public virtual DbSet<Table_2> Table_2 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table_1>()
                .Property(e => e.Cars)
                .IsUnicode(false);

            modelBuilder.Entity<Table_1>()
                .Property(e => e.Models)
                .IsUnicode(false);

            modelBuilder.Entity<Table_2>()
                .Property(e => e.Cars)
                .IsUnicode(false);

            modelBuilder.Entity<Table_2>()
                .Property(e => e.NumberPlate)
                .IsUnicode(false);
        }
    }
}
