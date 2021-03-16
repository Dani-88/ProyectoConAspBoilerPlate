using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABM_Test.Configuration.Dto;

namespace ABM_Test.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABM_TestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
