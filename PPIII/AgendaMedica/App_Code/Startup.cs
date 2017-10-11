using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgendaMedica.Startup))]
namespace AgendaMedica
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
