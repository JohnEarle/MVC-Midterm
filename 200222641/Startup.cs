using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_200222641.Startup))]
namespace _200222641
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
