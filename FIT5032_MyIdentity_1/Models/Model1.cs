using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_MyIdentity_1.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=FIT_5032Models")
        {
        }

        public virtual DbSet<STUDENT> STUDENTS { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<STUDENT>()
                .HasMany(e => e.Units)
                .WithRequired(e => e.STUDENT)
                .WillCascadeOnDelete(false);
        }
    }
}
