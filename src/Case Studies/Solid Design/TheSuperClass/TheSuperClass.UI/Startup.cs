using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheSuperClass.UI.Startup))]
namespace TheSuperClass.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
