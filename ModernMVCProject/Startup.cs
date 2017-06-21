using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModernMVCProject.Startup))]
namespace ModernMVCProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
