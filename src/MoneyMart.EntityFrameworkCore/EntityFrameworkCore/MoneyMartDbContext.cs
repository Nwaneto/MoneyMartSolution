using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MoneyMart.Authorization.Roles;
using MoneyMart.Authorization.Users;
using MoneyMart.MultiTenancy;

namespace MoneyMart.EntityFrameworkCore
{
    public class MoneyMartDbContext : AbpZeroDbContext<Tenant, Role, User, MoneyMartDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MoneyMartDbContext(DbContextOptions<MoneyMartDbContext> options)
            : base(options)
        {
        }
    }
}
