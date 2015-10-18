using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HereIYam.Startup))]

namespace HereIYam
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
