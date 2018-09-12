using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace OneWorkFlow.EntityFrameworkCore
{
    public static class OneWorkFlowDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OneWorkFlowDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OneWorkFlowDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
