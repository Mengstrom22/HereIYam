[assembly: Microsoft.Owin.OwinStartup(typeof(HereIYam.App_Start.Startup))]
namespace HereIYam.App_Start
{
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}