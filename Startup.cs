using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SA7810PRG522_WebApp.Startup))]
namespace SA7810PRG522_WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
