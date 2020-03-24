using System.Threading.Tasks;
using Abp.Application.Services;
using ABPProject.Sessions.Dto;

namespace ABPProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
