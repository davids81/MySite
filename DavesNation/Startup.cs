using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DavesNation.Startup))]
namespace DavesNation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
