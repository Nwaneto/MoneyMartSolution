using Abp.Application.Services;
using MoneyMart.MultiTenancy.Dto;

namespace MoneyMart.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

