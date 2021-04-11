using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Food__Delivery.Startup))]
namespace Food__Delivery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
