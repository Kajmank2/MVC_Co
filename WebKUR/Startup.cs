using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebKUR.Startup))]
namespace WebKUR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
