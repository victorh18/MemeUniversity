using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

//DAL, or Data Access Layer
namespace ContosoUniversity.DAL
{  
    //A DbContext class manages the functionality of a model
    public class SchoolContext : DbContext
    {
        //This specifies the name of the connection string 
        public SchoolContext() : base("SchoolContext")
        {

        }
        //DbSets represent the tables in the database, and an entity represents a row
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Keeps the database from creating the tables with plural forms of the models
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}