using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultiTenancy.Startup))]
namespace MultiTenancy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
