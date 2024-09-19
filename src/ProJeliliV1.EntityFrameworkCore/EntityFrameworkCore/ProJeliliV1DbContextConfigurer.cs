using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ProJeliliV1.EntityFrameworkCore
{
    public static class ProJeliliV1DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProJeliliV1DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProJeliliV1DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
