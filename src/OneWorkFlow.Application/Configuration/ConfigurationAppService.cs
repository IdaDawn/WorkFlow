using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using OneWorkFlow.Configuration.Dto;

namespace OneWorkFlow.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OneWorkFlowAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
