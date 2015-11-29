using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecretSanta.Startup))]
namespace SecretSanta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
