using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MysqlConnect.Startup))]
namespace MysqlConnect
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
