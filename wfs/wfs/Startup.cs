using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wfs.Startup))]
namespace wfs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
