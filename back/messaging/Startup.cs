[assembly: Microsoft.Owin.OwinStartup(typeof(HereIYam.Startup))]
namespace HereIYam
{
    using Microsoft.AspNet.SignalR;
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
