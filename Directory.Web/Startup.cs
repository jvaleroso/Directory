using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Directory.Web.Startup))]
namespace Directory.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
