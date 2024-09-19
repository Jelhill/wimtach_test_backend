using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ProJeliliV1.Configuration;
using ProJeliliV1.EntityFrameworkCore;
using ProJeliliV1.Migrator.DependencyInjection;

namespace ProJeliliV1.Migrator
{
    [DependsOn(typeof(ProJeliliV1EntityFrameworkModule))]
    public class ProJeliliV1MigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ProJeliliV1MigratorModule(ProJeliliV1EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ProJeliliV1MigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ProJeliliV1Consts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProJeliliV1MigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
