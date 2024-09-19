using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ProJeliliV1.Configuration;
using ProJeliliV1.Web;

namespace ProJeliliV1.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ProJeliliV1DbContextFactory : IDesignTimeDbContextFactory<ProJeliliV1DbContext>
    {
        public ProJeliliV1DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ProJeliliV1DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ProJeliliV1DbContextConfigurer.Configure(builder, configuration.GetConnectionString(ProJeliliV1Consts.ConnectionStringName));

            return new ProJeliliV1DbContext(builder.Options);
        }
    }
}
