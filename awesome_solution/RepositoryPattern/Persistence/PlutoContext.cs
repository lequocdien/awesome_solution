using RepositoryPattern.Core.Domain;
using RepositoryPattern.Persistence.EntityConfigurations;
using System.Data.Entity;

namespace RepositoryPattern.Persistence
{
    public class PlutoContext : DbContext
    {
        public PlutoContext()
            : base("PlutoContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration());
        }
    }
}
