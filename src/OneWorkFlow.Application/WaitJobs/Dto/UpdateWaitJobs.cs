using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OneWorkFlow.WaitJobs.Dto
{
    [AutoMap(typeof(WaitJobs))]
    public class UpdateWaitJobs : EntityDto<string>
    {
        /// <summary>
        /// 完成状态 0 未完成  1 完成  2 退回  3 驳回 
        /// </summary>
        public int isCompleted { get; set; }
        /// <summary>
        /// 更新人
        /// </summary>
        public string LastModifierUserId { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? LastModificationTime { get; set; }
    }
}
