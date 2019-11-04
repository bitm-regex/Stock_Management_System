using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StockManagementSystem.Startup))]
namespace StockManagementSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
