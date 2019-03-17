using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ep229.Startup))]
namespace ep229
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
