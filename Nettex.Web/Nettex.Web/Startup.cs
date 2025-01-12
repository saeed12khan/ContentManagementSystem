using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nettex.WebMVC.Startup))]
namespace Nettex.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }        
    }
}