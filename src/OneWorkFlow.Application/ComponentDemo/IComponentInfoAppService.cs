using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using OneWorkFlow.ComponentDemo.Dto;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;

namespace OneWorkFlow.ComponentDemo
{
    public interface IComponentInfoAppService : IAsyncCrudAppService<ComponentInfoDto, int, PagedResultRequestDto, CreateComponentInfoDto, UpdateComponentInfoDto>
    {
    }
}
