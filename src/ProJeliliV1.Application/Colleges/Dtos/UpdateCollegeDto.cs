using ProJeliliV1.Models;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace ProJeliliV1.Colleges.Dto
{
    [AutoMapTo(typeof(College))]
    public class UpdateCollegeDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public double GPSLatitude { get; set; }
        public double GPSLongitude { get; set; }
        public string Email { get; set; }
        public string JeliliString { get; set; }
        public bool IsActive { get; set; }
    }
}
