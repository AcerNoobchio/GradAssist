using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GradAssistASP.Startup))]
namespace GradAssistASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
