using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;

[assembly: OwinStartup(typeof(Market.Web.Api.Startup))]

namespace Market.Web.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
           
            //WebApiConfig.Register(config);
            //appBuilder.UseWebApi(config);
            appBuilder.UseCors(CorsOptions.AllowAll);
            appBuilder.UseNinjectMiddleware(NinjectWebCommon.CreateKernel).UseNinjectWebApi(WebApiConfig.Register());
        }
    }
}