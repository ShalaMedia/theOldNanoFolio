using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nanoFolio.Startup))]
namespace nanoFolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
