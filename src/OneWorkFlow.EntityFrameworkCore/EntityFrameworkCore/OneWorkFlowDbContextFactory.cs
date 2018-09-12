using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using OneWorkFlow.Configuration;
using OneWorkFlow.Web;

namespace OneWorkFlow.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class OneWorkFlowDbContextFactory : IDesignTimeDbContextFactory<OneWorkFlowDbContext>
    {
        public OneWorkFlowDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OneWorkFlowDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            OneWorkFlowDbContextConfigurer.Configure(builder, configuration.GetConnectionString(OneWorkFlowConsts.ConnectionStringName));

            return new OneWorkFlowDbContext(builder.Options);
        }
    }
}
