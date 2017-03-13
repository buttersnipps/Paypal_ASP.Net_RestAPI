using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(paypaltest.Startup))]
namespace paypaltest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
