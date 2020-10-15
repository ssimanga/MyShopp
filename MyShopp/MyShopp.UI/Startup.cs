using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShopp.UI.Startup))]
namespace MyShopp.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
