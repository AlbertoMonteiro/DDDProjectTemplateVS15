using System.Data.Entity;

namespace $safeprojectname$
{
    public class ProjectNameContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(ProjectNameContext).Assembly);
        }
    }
}
