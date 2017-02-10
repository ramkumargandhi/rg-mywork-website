using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(rg_mywork_website.Startup))]
namespace rg_mywork_website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
