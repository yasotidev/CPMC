using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CPMC.Startup))]

namespace CPMC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
