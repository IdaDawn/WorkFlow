using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OneWorkFlow.Authorization.Roles;
using OneWorkFlow.Authorization.Users;
using OneWorkFlow.MultiTenancy;
using OneWorkFlow.ComponentDemo;

namespace OneWorkFlow.EntityFrameworkCore
{
    public class OneWorkFlowDbContext : AbpZeroDbContext<Tenant, Role, User, OneWorkFlowDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public OneWorkFlowDbContext(DbContextOptions<OneWorkFlowDbContext> options)
            : base(options)
        {
        }

        public DbSet<ComponentInfo> ComponentInfos { get; set; }

        public DbSet<WorkFlowStatus> WorkFlowStatus { get; set; }

        public DbSet<OneWorkFlow.WaitJobs.WaitJobs> waitJobs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ComponentInfo>().ToTable("wf_ComponentInfo");
            modelBuilder.Entity<WorkFlowStatus>().ToTable("wf_WorkFlowStatus");
            modelBuilder.Entity<OneWorkFlow.WaitJobs.WaitJobs>().ToTable("wf_WaitJobs");

            base.OnModelCreating(modelBuilder);
        }
    }
}
