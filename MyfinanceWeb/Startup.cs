using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyfinanceWeb.Startup))]
namespace MyfinanceWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
