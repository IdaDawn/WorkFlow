using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OneWorkFlow.Roles.Dto;

namespace OneWorkFlow.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();

        Task<GetRoleForEditOutput> GetRoleForEdit(EntityDto input);
    }
}