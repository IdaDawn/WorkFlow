using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OneWorkFlow.WaitJobs.Dto
{
    [AutoMap(typeof(WaitJobs))]
    public class WaitJobsDto : EntityDto<string>
    {
        /// <summary>
        /// 标题
        /// </summary>
        [Required]
        public string title { get; set; }
        /// <summary>
        /// Url 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 传递参数
        /// </summary>
        public string param { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        [Required]
        public int types { get; set; }
        /// <summary>
        /// 发送人
        /// </summary>
        [Required]
        public string senderId { get; set; }
        /// <summary>
        /// 接收人
        /// </summary>
        [Required]
        public string receiveId { get; set; }
        /// <summary>
        /// 完成状态 0 未完成  1 完成  2 退回  3 驳回 
        /// </summary>
        public int isCompleted { get; set; }
        /// <summary>
        /// 是否超期
        /// </summary>
        public int isOverdue { get; set; }
        /// <summary>
        /// 优先级  默认0
        /// </summary>
        public int priority { get; set; }
    }
}
