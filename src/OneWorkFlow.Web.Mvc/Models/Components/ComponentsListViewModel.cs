using OneWorkFlow.ComponentDemo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneWorkFlow.Web.Models.Components
{
    public class ComponentsListViewModel
    {
        public IReadOnlyList<ComponentInfoDto> ComponentInfos { get; set; }
    }
}
