using System.Threading.Tasks;
using Abp.Application.Services;
using ABPProject.Authorization.Accounts.Dto;

namespace ABPProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
