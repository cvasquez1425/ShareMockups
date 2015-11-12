using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShareMockups.Startup))]
namespace ShareMockups
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
