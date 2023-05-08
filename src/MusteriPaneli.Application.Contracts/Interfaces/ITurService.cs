using MusteriPaneli.Dtos;
using MusteriPaneli.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace MusteriPaneli.Interfaces
{
    public interface ITurService : IApplicationService, IScopedDependency
    {
        Task<List<TurDto<AdresTuru>>> GetAdresTurleriAsync();
        Task<List<TurDto<OdemeTuru>>> GetOdemeTurleriAsync();
        Task<List<TurDto<TelefonTuru>>> GetTelefonTurleriAsync();
    }
}