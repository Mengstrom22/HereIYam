using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Browser.Startup))]
namespace Browser
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}