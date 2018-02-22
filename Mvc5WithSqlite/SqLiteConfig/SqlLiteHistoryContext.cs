using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;

namespace Mvc5WithSqlite.SqLiteConfig
{
    public class SqlLiteHistoryContext : HistoryContext
    {
        public SqlLiteHistoryContext(
            DbConnection existingConnection,
            string defaultSchema)
            : base(existingConnection, defaultSchema)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<HistoryRow>().Property(h => h.MigrationId).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<HistoryRow>().Property(h => h.ContextKey).HasMaxLength(200).IsRequired();
        }
    }
}
