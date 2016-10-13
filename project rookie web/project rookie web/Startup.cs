using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(project_rookie_web.Startup))]
namespace project_rookie_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
