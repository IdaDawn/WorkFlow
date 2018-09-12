using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using OneWorkFlow.ComponentDemo.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneWorkFlow.ComponentDemo
{
    public class ComponentInfoAppService : AsyncCrudAppService<ComponentInfo, ComponentInfoDto, int, PagedResultRequestDto, CreateComponentInfoDto, UpdateComponentInfoDto>, IComponentInfoAppService
    {
        public ComponentInfoAppService(IRepository<ComponentInfo> repository)
            : base(repository)
        {
        }
    }
}
