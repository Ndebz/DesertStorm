using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DesertStorm.Startup))]
namespace DesertStorm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
