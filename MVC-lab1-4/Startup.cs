using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_lab1_4.Startup))]
namespace MVC_lab1_4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
