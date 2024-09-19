using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ProJeliliV1.Authorization.Roles;
using ProJeliliV1.Authorization.Users;
using ProJeliliV1.MultiTenancy;
using ProJeliliV1.Models;

namespace ProJeliliV1.EntityFrameworkCore
{
    public class ProJeliliV1DbContext : AbpZeroDbContext<Tenant, Role, User, ProJeliliV1DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ProJeliliV1DbContext(DbContextOptions<ProJeliliV1DbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Abp.Localization.ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100);

        } 
        
        public virtual DbSet<Student> Students { get; set; }
        
        public virtual DbSet<College> Colleges { get; set; }

    }
}
