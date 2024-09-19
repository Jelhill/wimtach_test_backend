using Abp.Application.Services.Dto;

namespace ProJeliliV1.Colleges.Dto
{
    public class PagedCollegeResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}