namespace GradesNamespace
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StudentGrades : DbContext
    {
        public StudentGrades()
            : base("name=StudentGrades")
        {
        }

        public virtual DbSet<GradeTable> GradeTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
