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
        /// <param name="currentUserId">当前用户</param>
        /// <param name="type">类别</param>
        /// <param name="status">状态</param>
        /// <returns></returns>
        Task<PagedResultDto<WaitJobsDto>> GetWaitList(string currentUserId, int type, int status,PagedResultRequestDto input);
    }
}
