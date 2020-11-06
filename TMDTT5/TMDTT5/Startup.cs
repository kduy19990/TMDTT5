using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMDTT5.Startup))]
namespace TMDTT5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
