using System.Threading.Tasks;
using Abp.Application.Services;
using OneWorkFlow.Authorization.Accounts.Dto;

namespace OneWorkFlow.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
