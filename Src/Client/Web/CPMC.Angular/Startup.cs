using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CPMC.Angular.Startup))]

namespace CPMC.Angular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
