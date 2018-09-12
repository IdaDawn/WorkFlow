using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Domain.Entities.Auditing;

namespace OneWorkFlow.ComponentDemo
{
    public class ComponentInfo : FullAuditedEntity
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

        public List<WorkFlowStatus> WorkFlowStatuses { get; set; }

    }
}
