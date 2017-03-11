using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcformsauthentication.Startup))]
namespace mvcformsauthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
