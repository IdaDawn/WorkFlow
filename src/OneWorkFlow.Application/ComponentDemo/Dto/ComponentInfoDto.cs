using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace OneWorkFlow.ComponentDemo.Dto
{
    [AutoMap(typeof(ComponentInfo))]
    public class ComponentInfoDto : EntityDto<int>
    {
        /// <summary>
        /// 构件名称
        /// </summary>
        public string ComponentName { get; set; }

        /// <summary>
        /// 构件类型
        /// </summary>
        public string ComponentSort { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime? LastModificationTime { get; set; }
    }
}
