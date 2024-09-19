using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProJeliliV1.EntityFrameworkCore;
using ProJeliliV1.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ProJeliliV1.Web.Tests
{
    [DependsOn(
        typeof(ProJeliliV1WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ProJeliliV1WebTestModule : AbpModule
    {
        public ProJeliliV1WebTestModule(ProJeliliV1EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProJeliliV1WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ProJeliliV1WebMvcModule).Assembly);
        }
    }
}