using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Avaliacao.Startup))]
namespace Avaliacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
