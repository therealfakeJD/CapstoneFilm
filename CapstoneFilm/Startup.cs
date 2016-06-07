using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CapstoneFilm.Startup))]
namespace CapstoneFilm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
