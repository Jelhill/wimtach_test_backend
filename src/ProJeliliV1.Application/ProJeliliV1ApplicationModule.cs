using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProJeliliV1.Authorization;

namespace ProJeliliV1
{
    [DependsOn(
        typeof(ProJeliliV1CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ProJeliliV1ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ProJeliliV1AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ProJeliliV1ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
