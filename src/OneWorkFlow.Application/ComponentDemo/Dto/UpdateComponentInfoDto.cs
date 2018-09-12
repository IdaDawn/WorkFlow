using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OneWorkFlow.ComponentDemo.Dto
{
    [AutoMap(typeof(ComponentInfo))]
    public class UpdateComponentInfoDto : EntityDto<int>
    {
        /// <summary>
        /// 构件名称
        /// </summary>
        [Required]
        public string ComponentName { get; set; }

        /// <summary>
        /// 构件类型
        /// </summary>
        [Required]
        public string ComponentSort { get; set; }

    }
}
