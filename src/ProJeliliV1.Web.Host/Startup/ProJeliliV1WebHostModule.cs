using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProJeliliV1.Configuration;

namespace ProJeliliV1.Web.Host.Startup
{
    [DependsOn(
       typeof(ProJeliliV1WebCoreModule))]
    public class ProJeliliV1WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ProJeliliV1WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProJeliliV1WebHostModule).GetAssembly());
        }
    }
}
