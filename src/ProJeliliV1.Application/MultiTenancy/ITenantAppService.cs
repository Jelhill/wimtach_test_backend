using Abp.Application.Services;
using ProJeliliV1.MultiTenancy.Dto;

namespace ProJeliliV1.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

