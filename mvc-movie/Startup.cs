using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvc_movie.Startup))]
namespace mvc_movie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
