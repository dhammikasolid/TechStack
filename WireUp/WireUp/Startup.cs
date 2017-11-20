using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WireUp.Startup))]
namespace WireUp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
