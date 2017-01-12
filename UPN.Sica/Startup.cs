using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UPN.Sica.Startup))]
namespace UPN.Sica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
