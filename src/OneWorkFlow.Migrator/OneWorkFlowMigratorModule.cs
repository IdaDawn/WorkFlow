using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OneWorkFlow.Configuration;
using OneWorkFlow.EntityFrameworkCore;
using OneWorkFlow.Migrator.DependencyInjection;

namespace OneWorkFlow.Migrator
{
    [DependsOn(typeof(OneWorkFlowEntityFrameworkModule))]
    public class OneWorkFlowMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public OneWorkFlowMigratorModule(OneWorkFlowEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(OneWorkFlowMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                OneWorkFlowConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(OneWorkFlowMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
