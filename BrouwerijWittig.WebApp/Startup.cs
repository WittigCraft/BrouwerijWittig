using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrouwerijWittig.WebApp.Startup))]
namespace BrouwerijWittig.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
