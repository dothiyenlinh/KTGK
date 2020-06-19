using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KTGK.Startup))]
namespace KTGK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
