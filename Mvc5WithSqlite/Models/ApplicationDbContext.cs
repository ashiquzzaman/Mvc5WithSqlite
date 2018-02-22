using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Mvc5WithSqlite.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //  modelBuilder.Conventions.Add(new DateConvention());

        }








        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}