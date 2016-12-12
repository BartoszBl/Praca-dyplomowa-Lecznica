using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecznica.Startup))]
namespace Lecznica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
