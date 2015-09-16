using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticeWebsite.Startup))]
namespace PracticeWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
