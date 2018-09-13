using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Application.Services.Dto;
using Abp.Runtime.Validation;

namespace OneWorkFlow.WaitJobs.Dto
{
    public class GetWaitListInput : PagedAndSortedResultRequestDto, IShouldNormalize, ICustomValidate
    {
        [Required]
        public string currentUserId { get; set; }

        public string types { get; set; }

        public string status { get; set; }

        int isInt = 0;
        public void Normalize()
        {

        }

        public void AddValidationErrors(CustomValidationContext context)
        {
            if (string.IsNullOrEmpty(currentUserId))
            {
                context.Results.Add(new ValidationResult("输入查询人员错误！"));
            }
            if (string.IsNullOrEmpty(types) == false && int.TryParse(types, out isInt) == false)
            {
                context.Results.Add(new ValidationResult("输入查询类型错误！"));
            }
            if (string.IsNullOrEmpty(status) == false && int.TryParse(status, out isInt) == false)
            {
                context.Results.Add(new ValidationResult("输入查询状态错误！"));
            }
        }
    }
}
