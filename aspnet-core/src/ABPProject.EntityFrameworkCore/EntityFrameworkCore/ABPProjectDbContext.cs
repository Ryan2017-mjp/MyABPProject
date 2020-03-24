using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABPProject.Authorization.Roles;
using ABPProject.Authorization.Users;
using ABPProject.MultiTenancy;

namespace ABPProject.EntityFrameworkCore
{
    public class ABPProjectDbContext : AbpZeroDbContext<Tenant, Role, User, ABPProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPProjectDbContext(DbContextOptions<ABPProjectDbContext> options)
            : base(options)
        {
        }
    }
}
