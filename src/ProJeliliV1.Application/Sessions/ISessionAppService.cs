using System.Threading.Tasks;
using Abp.Application.Services;
using ProJeliliV1.Sessions.Dto;

namespace ProJeliliV1.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
