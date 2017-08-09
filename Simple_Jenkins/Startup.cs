using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Simple_Jenkins.Startup))]
namespace Simple_Jenkins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
