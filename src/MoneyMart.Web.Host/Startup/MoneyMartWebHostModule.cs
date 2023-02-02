using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MoneyMart.Configuration;

namespace MoneyMart.Web.Host.Startup
{
    [DependsOn(
       typeof(MoneyMartWebCoreModule))]
    public class MoneyMartWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MoneyMartWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MoneyMartWebHostModule).GetAssembly());
        }
    }
}
