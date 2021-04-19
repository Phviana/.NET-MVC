namespace Dev.Infra.Migrations
{
    using Dev.Infra.Data.Context;
    using System.Data.Entity.Migrations;


    internal sealed class Configuration : DbMigrationsConfiguration<MyDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

    }
}
