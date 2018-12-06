using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuintanaLawWS.Startup))]
namespace QuintanaLawWS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
