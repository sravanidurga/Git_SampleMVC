using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git_SampleMVC.Startup))]
namespace Git_SampleMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
