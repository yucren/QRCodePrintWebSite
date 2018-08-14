using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QRCodePrint.Startup))]
namespace QRCodePrint
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
