using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MoneyMart.Configuration.Dto;

namespace MoneyMart.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MoneyMartAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
