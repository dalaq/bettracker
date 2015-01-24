using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bettracker.web.ui.Startup))]
namespace bettracker.web.ui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
