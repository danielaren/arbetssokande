using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Arbetssokande.Startup))]
namespace Arbetssokande
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
