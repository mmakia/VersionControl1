using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VersionControl1.Startup))]
namespace VersionControl1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
