using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OneWorkFlow.Configuration;

namespace OneWorkFlow.Web.Startup
{
    [DependsOn(typeof(OneWorkFlowWebCoreModule))]
    public class OneWorkFlowWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OneWorkFlowWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<OneWorkFlowNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OneWorkFlowWebMvcModule).GetAssembly());
        }
    }
}
