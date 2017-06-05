using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BPShop.Startup))]
namespace BPShop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
