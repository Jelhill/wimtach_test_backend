using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ProJeliliV1.Authorization.Roles;
using ProJeliliV1.Authorization.Users;
using ProJeliliV1.MultiTenancy;

namespace ProJeliliV1.EntityFrameworkCore
{
    public class ProJeliliV1DbContext : AbpZeroDbContext<Tenant, Role, User, ProJeliliV1DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ProJeliliV1DbContext(DbContextOptions<ProJeliliV1DbContext> options)
            : base(options)
        {
        }
    }
}
