using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OneWorkFlow.WaitJobs.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OneWorkFlow.WaitJobs
{
    public interface IWaitJobsAppService : IAsyncCrudAppService<WaitJobsDto, string, PagedResultRequestDto, CreateWaitJobs, UpdateWaitJobs>
    {
        /// <summary>
        /// 获取待办列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<WaitJobsDto>> GetWaitList(GetWaitListInput input);

        //Task<WaitJobsDto> UpdateStatus();
    }
}
