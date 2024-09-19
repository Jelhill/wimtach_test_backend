using Abp.Application.Services.Dto;

namespace ProJeliliV1.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

