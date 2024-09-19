using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ProJeliliV1.Configuration.Dto;

namespace ProJeliliV1.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ProJeliliV1AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
