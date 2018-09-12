using System.Collections.Generic;
using OneWorkFlow.Roles.Dto;

namespace OneWorkFlow.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}