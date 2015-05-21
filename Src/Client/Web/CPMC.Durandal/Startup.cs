using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CPMC.Durandal.Startup))]

namespace CPMC.Durandal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
