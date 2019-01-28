using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Admin.Web.Startup))]
namespace Admin.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
