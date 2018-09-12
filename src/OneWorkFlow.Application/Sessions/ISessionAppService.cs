using System.Threading.Tasks;
using Abp.Application.Services;
using OneWorkFlow.Sessions.Dto;

namespace OneWorkFlow.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
