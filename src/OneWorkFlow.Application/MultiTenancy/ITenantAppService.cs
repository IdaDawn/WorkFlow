using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OneWorkFlow.MultiTenancy.Dto;

namespace OneWorkFlow.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
