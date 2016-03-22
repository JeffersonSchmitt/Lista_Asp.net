using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula3.Startup))]
namespace Aula3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
