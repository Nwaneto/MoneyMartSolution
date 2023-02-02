using System.Threading.Tasks;
using Abp.Application.Services;
using MoneyMart.Sessions.Dto;

namespace MoneyMart.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
