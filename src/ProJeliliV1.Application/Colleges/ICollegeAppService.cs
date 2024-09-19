using Abp.Application.Services;
using ProJeliliV1.Colleges.Dto;

namespace ProJeliliV1.Colleges
{
    public interface ICollegeAppService : IAsyncCrudAppService<CollegeDto, int, PagedCollegeResultRequestDto, CreateCollegeDto, UpdateCollegeDto>
    {
    }
}