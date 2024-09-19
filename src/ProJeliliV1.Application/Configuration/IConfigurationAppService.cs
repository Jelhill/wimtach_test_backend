using System.Threading.Tasks;
using ProJeliliV1.Configuration.Dto;

namespace ProJeliliV1.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
