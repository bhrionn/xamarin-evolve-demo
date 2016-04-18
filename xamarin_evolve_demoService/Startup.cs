using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(xamarin_evolve_demoService.Startup))]

namespace xamarin_evolve_demoService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}