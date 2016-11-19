using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Standart_test.Startup))]
namespace Standart_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
