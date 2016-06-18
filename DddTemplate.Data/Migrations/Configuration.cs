using System.Data.Entity.Migrations;

namespace $safeprojectname$.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ProjectNameContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProjectNameContext context)
        {
        }
    }
}
