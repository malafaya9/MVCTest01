using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTest01.Startup))]
namespace MVCTest01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
