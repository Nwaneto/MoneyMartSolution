using System.Threading.Tasks;
using MoneyMart.Configuration.Dto;

namespace MoneyMart.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
