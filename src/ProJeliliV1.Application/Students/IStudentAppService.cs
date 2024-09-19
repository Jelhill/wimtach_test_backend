using Abp.Application.Services;
using ProJeliliV1.Students.Dto;


namespace ProJeliliV1.Students
{
    public interface IStudentAppService : IAsyncCrudAppService<StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, UpdateStudentDto>
    {
      
    }
}