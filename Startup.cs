using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GaoMengWeb.Startup))]
namespace GaoMengWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
