using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABM_Test.MultiTenancy.Dto;

namespace ABM_Test.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
