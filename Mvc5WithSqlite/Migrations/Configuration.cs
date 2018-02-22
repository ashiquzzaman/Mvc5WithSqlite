using Mvc5WithSqlite.SqLiteConfig;

namespace Mvc5WithSqlite.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Mvc5WithSqlite.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("System.Data.SQLite", new MigrationSqLiteGenerator());
            SetHistoryContextFactory("System.Data.SQLite", (conn, schema) => new SqlLiteHistoryContext(conn, schema));
        }

        protected override void Seed(Mvc5WithSqlite.Models.ApplicationDbContext context)
        {


            //context.People.AddOrUpdate(
            //  p => p.FullName,
            //  new Person { FullName = "Andrew Peters" },
            //  new Person { FullName = "Brice Lambson" },
            //  new Person { FullName = "Rowan Miller" }
            //);

        }
    }
}
