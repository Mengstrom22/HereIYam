[assembly: Microsoft.Owin.OwinStartup(typeof(HereIYam.Startup))]
namespace HereIYam
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}