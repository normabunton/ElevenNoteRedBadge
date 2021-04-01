using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElevenNote.WebMVCRedBadge.Startup))]
namespace ElevenNote.WebMVCRedBadge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
