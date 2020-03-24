using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABPProject.Configuration;
using ABPProject.Web;

namespace ABPProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABPProjectDbContextFactory : IDesignTimeDbContextFactory<ABPProjectDbContext>
    {
        public ABPProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABPProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABPProjectConsts.ConnectionStringName));

            return new ABPProjectDbContext(builder.Options);
        }
    }
}
