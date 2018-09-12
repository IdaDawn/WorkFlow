using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OneWorkFlow.Configuration;

namespace OneWorkFlow.Web.Host.Startup
{
    [DependsOn(
       typeof(OneWorkFlowWebCoreModule))]
    public class OneWorkFlowWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OneWorkFlowWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OneWorkFlowWebHostModule).GetAssembly());
        }
    }
}
