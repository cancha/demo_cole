using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Colegio_Jean.Startup))]
namespace Colegio_Jean
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
