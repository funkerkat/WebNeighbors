using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebNeighbors.Startup))]
namespace WebNeighbors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
