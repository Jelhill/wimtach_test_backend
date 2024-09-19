using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using ProJeliliV1.Models;
using ProJeliliV1.Students.Dto;

namespace ProJeliliV1.Students
{

    // [AbpAuthorize(PermissionNames.Pages_Students)]
    public class StudentAppService :
        AsyncCrudAppService<Student, StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, UpdateStudentDto>,
        IStudentAppService
    {
        
        public StudentAppService
        (
            IRepository<Student, int> studentRepository
        )
            : base(studentRepository)
        {
            
        }

    }
}