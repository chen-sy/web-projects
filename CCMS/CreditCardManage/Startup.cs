using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CreditCardManage.Startup))]
namespace CreditCardManage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
