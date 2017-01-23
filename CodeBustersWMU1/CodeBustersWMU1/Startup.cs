using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeBustersWMU1.Startup))]
namespace CodeBustersWMU1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
