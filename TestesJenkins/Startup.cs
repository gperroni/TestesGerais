using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestesJenkins.Startup))]
namespace TestesJenkins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
