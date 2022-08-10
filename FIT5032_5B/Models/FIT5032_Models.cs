using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_5B.Models
{
    public partial class FIT5032_Models : DbContext
    {
        public FIT5032_Models()
            : base("name=FIT5032_Models")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<UnitSet> UnitSets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(e => e.UnitSets)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
        }
    }
}
