using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OneWorkFlow.ComponentDemo.Dto
{
    /// <summary>
    /// 添加构件实体类
    /// </summary>
    [AutoMap(typeof(ComponentInfo))]
    public class CreateComponentInfoDto
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

        /// <summary>
        /// 是否完成
        /// </summary>
        [Required]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public long CreatorUserId { get; set; }
    }
}
