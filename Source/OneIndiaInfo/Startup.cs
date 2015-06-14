using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneIndiaInfo.Startup))]
namespace OneIndiaInfo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
