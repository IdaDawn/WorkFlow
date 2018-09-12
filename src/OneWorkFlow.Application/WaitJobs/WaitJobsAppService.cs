using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using OneWorkFlow.WaitJobs.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OneWorkFlow.WaitJobs
{
    public class WaitJobsAppService : AsyncCrudAppService<WaitJobs, WaitJobsDto, string, PagedResultRequestDto, CreateWaitJobs, UpdateWaitJobs>, IWaitJobsAppService
    {
        public WaitJobsAppService(IRepository<WaitJobs, string> repository)
           : base(repository)
        {
        }
        public async Task<PagedResultDto<WaitJobsDto>> GetWaitList(string currentUserId, int type, int status, PagedResultRequestDto input)
        {
            //Expression<Func<WaitJobs, bool>> query = null;
            var waitJobs = await Repository.GetAllListAsync(t => t.senderId.Equals(currentUserId) && t.types.Equals(type) && t.isCompleted.Equals(status));
            var count = await Repository.CountAsync(t => t.senderId.Equals(currentUserId) && t.types.Equals(type) && t.isCompleted.Equals(status));
            return new PagedResultDto<WaitJobsDto>(count, ObjectMapper.Map<List<WaitJobsDto>>(waitJobs));
        }
    }
}
