using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OneWorkFlow.Roles.Dto;
using OneWorkFlow.Users.Dto;

namespace OneWorkFlow.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
