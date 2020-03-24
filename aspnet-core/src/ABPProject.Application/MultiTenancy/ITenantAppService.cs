using Abp.Application.Services;
using ABPProject.MultiTenancy.Dto;

namespace ABPProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

