using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Backbone.Startup))]
namespace Backbone
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
