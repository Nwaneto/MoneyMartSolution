using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MoneyMart.Authorization;

namespace MoneyMart
{
    [DependsOn(
        typeof(MoneyMartCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MoneyMartApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MoneyMartAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MoneyMartApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
