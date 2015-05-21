using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CPMC.Scaffolding.Startup))]

namespace CPMC.Scaffolding
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
