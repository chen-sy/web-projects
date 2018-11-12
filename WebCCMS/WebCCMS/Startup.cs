using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebCCMS.Startup))]
namespace WebCCMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
