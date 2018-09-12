using System.Threading.Tasks;
using OneWorkFlow.Configuration.Dto;

namespace OneWorkFlow.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
