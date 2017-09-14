using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week2_MVCMusicStore.Startup))]
namespace Week2_MVCMusicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
