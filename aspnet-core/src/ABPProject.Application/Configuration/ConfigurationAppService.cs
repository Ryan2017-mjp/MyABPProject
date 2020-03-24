using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPProject.Configuration.Dto;

namespace ABPProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
