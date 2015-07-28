using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnetmvc_angular.Startup))]
namespace aspnetmvc_angular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
