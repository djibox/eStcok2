using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eStock2.Startup))]
namespace eStock2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
