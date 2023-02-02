using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MoneyMart.EntityFrameworkCore;
using MoneyMart.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MoneyMart.Web.Tests
{
    [DependsOn(
        typeof(MoneyMartWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MoneyMartWebTestModule : AbpModule
    {
        public MoneyMartWebTestModule(MoneyMartEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MoneyMartWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MoneyMartWebMvcModule).Assembly);
        }
    }
}