using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ProJeliliV1.MultiTenancy;

namespace ProJeliliV1.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
