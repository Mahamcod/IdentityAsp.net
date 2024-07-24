using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityAsp.net.Startup))]
namespace IdentityAsp.net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}



