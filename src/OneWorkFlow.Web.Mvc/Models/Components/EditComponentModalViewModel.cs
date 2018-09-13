using Abp.AutoMapper;
using OneWorkFlow.ComponentDemo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneWorkFlow.Web.Models.Components
{
    [AutoMapFrom(typeof(ComponentInfoDto))]
    public class EditComponentModalViewModel: ComponentInfoDto
    {
        public EditComponentModalViewModel(ComponentInfoDto output)
        {
            output.MapTo(this);
        }
    }
}
