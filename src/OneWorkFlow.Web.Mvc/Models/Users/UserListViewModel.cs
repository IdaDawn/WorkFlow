using System.Collections.Generic;
using OneWorkFlow.Roles.Dto;
using OneWorkFlow.Users.Dto;

namespace OneWorkFlow.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
