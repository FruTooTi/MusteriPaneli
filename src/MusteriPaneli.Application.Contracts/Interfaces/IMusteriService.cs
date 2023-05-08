using MusteriPaneli.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;

namespace MusteriPaneli.Interfaces
{
    public interface IMusteriService : IApplicationService, IScopedDependency
    {
        Task<MusteriDto> DeleteAsync(Guid id);
        Task<List<MusteriDto>> GetAllAsync();
        Task<MusteriDto> GetAsync(Guid id);
        Task<CreateOrUpdateMusteriDto> InsertAsync(CreateOrUpdateMusteriDto input);
        Task<CreateOrUpdateMusteriDto> UpdateAsync(Guid id, CreateOrUpdateMusteriDto input);
    }
}