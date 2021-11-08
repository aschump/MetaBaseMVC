using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MetabaseMVC.Startup))]
namespace MetabaseMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
