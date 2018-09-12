using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace OneWorkFlow.ComponentDemo
{
    public class WorkFlowStatus : Entity, IHasCreationTime, IHasModificationTime
    {
        /// <summary>
        /// 流程Id 
        /// </summary>
        public string FlowId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string StepId { get; set; }
        /// <summary>
        /// Word
        /// </summary>
        public string TaskId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string InstanceId { get; set; }
        /// <summary>
        /// 是否完成
        /// </summary>
        public bool IsCompleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ComponentInfo component { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public DateTime CreationTime { get ; set ; }
    }
}
