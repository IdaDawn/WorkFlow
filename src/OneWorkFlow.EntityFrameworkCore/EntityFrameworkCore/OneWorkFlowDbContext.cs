using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OneWorkFlow.Authorization.Roles;
using OneWorkFlow.Authorization.Users;
using OneWorkFlow.MultiTenancy;

namespace OneWorkFlow.EntityFrameworkCore
{
    public class OneWorkFlowDbContext : AbpZeroDbContext<Tenant, Role, User, OneWorkFlowDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OneWorkFlowDbContext(DbContextOptions<OneWorkFlowDbContext> options)
            : base(options)
        {
        }
    }
}
