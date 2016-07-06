using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(www.RolandIO.dk.Startup))]
namespace www.RolandIO.dk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
