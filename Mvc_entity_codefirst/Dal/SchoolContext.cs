


using Mvc_entity_codefirst.Models;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;




namespace Mvc_entity_codefirst.Dal
{
    public class SchoolContext:DbContext
    //public SchoolContext() : base("SchoolContext")
    //{ }
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Course> Courses { get; set; }

        // prevents table names from being pluralized
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}