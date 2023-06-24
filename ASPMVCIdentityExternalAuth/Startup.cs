using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPMVCIdentityExternalAuth.Startup))]
namespace ASPMVCIdentityExternalAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
