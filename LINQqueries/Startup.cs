using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LINQqueries.Startup))]
namespace LINQqueries
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
