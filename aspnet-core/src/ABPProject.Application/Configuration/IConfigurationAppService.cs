using System.Threading.Tasks;
using ABPProject.Configuration.Dto;

namespace ABPProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
