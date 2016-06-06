using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SessiesAPP.Startup))]
namespace SessiesAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
