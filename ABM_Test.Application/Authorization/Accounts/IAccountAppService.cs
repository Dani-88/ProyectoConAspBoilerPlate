using System.Threading.Tasks;
using Abp.Application.Services;
using ABM_Test.Authorization.Accounts.Dto;

namespace ABM_Test.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
