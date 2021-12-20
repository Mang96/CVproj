using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Workshop1Real.Startup))]
namespace Workshop1Real
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
