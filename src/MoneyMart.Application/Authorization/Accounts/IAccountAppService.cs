using System.Threading.Tasks;
using Abp.Application.Services;
using MoneyMart.Authorization.Accounts.Dto;

namespace MoneyMart.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
