[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(HereIYam.SwaggerConfig), "Register")]
namespace HereIYam
{
    using System.Web.Http;
    using Swashbuckle.Application;

    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "HereIYam");
                    })
                .EnableSwaggerUi(c =>
                    {
                    });
        }
    }
}