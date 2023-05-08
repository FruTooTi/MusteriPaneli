using MusteriPaneli.Entities;
using MusteriPaneli.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MusteriPaneli.Interfaces
{
    public interface ITurRepository : IScopedDependency
    {
        Task<List<Tur<AdresTuru, Adres>>> GetAdresTurleriAsync();
        Task<List<Tur<OdemeTuru, OdemeMusteri>>> GetOdemeTurleriAsync();
        Task<List<Tur<TelefonTuru, Telefon>>> GetTelefonTurleriAsync();
    }
}