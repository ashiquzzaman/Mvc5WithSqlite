using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5WithSqlite.Startup))]
namespace Mvc5WithSqlite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
