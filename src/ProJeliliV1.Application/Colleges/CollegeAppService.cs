using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using ProJeliliV1.Authorization;
using ProJeliliV1.Models;
using ProJeliliV1.Colleges.Dto;

namespace ProJeliliV1.Colleges
{
    [AbpAuthorize(PermissionNames.Pages_Colleges)]
    public class CollegeAppService :
        AsyncCrudAppService<College, CollegeDto, int, PagedCollegeResultRequestDto, CreateCollegeDto, UpdateCollegeDto>,
        ICollegeAppService
    {
        private readonly IRepository<College, int> _collegeRepository;
        private readonly IObjectMapper _objectMapper;

        public CollegeAppService
        (
            IRepository<College, int> collegeRepository,
            IObjectMapper objectMapper
        )
            : base(collegeRepository)
        {
            _collegeRepository = collegeRepository;
            _objectMapper = objectMapper;
        }

        public async Task<List<CollegeDto>> GetMyCustomListAsync()
        {
            var colleges = await Repository.GetAllListAsync();
            colleges = colleges.Where(p => p.Id > 1).ToList();
            return _objectMapper.Map<List<CollegeDto>>(colleges);
        }

        public void CreateMyCustomCollege(CreateCollegeDto input)
        {
            var college = _objectMapper.Map<College>(input);
            _collegeRepository.Insert(college);
        }

        public void CreateMyCustomCollegeV2(CreateCollegeDto input)
        {
            var college = new College() { Name = input.Name + "-test", Address = input.Address + "-test" };
            college.Description = input.Description;
            college.GPSLatitude = input.GPSLatitude;
            college.GPSLongitude = input.GPSLongitude;
            college.Email = input.Email;
            Repository.Insert(college);
        }

        public async Task<CollegeDto> UpdateMyCustomCollegeAsync(UpdateCollegeDto input)
        {
            var college = await _collegeRepository.GetAsync(input.Id);
            _objectMapper.Map(input, college);

            await _collegeRepository.UpdateAsync(college);
            return _objectMapper.Map<CollegeDto>(college);
        }

        public async Task DeleteCollegeAsync(int id)
        {
            var college = await _collegeRepository.GetAsync(id);
            await _collegeRepository.DeleteAsync(college);
        }
    }
}
