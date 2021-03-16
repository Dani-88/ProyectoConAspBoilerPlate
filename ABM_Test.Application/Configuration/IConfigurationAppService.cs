using System.Threading.Tasks;
using Abp.Application.Services;
using ABM_Test.Configuration.Dto;

namespace ABM_Test.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}