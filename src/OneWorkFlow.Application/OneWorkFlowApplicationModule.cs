using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OneWorkFlow.Authorization;

namespace OneWorkFlow
{
    [DependsOn(
        typeof(OneWorkFlowCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OneWorkFlowApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OneWorkFlowAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OneWorkFlowApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
