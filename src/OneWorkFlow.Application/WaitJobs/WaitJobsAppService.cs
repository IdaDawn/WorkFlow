using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using OneWorkFlow.WaitJobs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OneWorkFlow.WaitJobs
{
    public class WaitJobsAppService : AsyncCrudAppService<WaitJobs, WaitJobsDto, string, PagedResultRequestDto, CreateWaitJobs, UpdateWaitJobs>, IWaitJobsAppService
    {
        private readonly IRepository<WaitJobs, string> _repository;
        public WaitJobsAppService(IRepository<WaitJobs, string> repository)
           : base(repository)
        {
            _repository = repository;
        }

        public async Task<PagedResultDto<WaitJobsDto>> GetWaitList(GetWaitListInput input)
        {
            var query = _repository.GetAll();
            if (!string.IsNullOrEmpty(input.currentUserId))
            {
                query = query.Where(m => m.receiveId == input.currentUserId);
            }
            if (!string.IsNullOrEmpty(input.types))
            {
                query = query.Where(m => m.types == int.Parse(input.types));
            }
            if (!string.IsNullOrEmpty(input.status))
            {
                query = query.Where(m => m.isCompleted == int.Parse(input.status));
            }
            var totalCount = await AsyncQueryableExecuter.CountAsync(query);
            query = ApplySorting(query, input);
            query = ApplyPaging(query, input);
            var waitJobs = await AsyncQueryableExecuter.ToListAsync(query);
            return new PagedResultDto<WaitJobsDto>(totalCount, ObjectMapper.Map<List<WaitJobsDto>>(waitJobs));
        }


    }
}
