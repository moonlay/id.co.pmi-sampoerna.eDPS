using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sampoerna.eDPS.Web.Startup))]
namespace Sampoerna.eDPS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
