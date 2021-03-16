using System.Threading.Tasks;
using Abp.Application.Services;
using ABM_Test.Sessions.Dto;

namespace ABM_Test.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
