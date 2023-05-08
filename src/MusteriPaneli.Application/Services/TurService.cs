using MusteriPaneli.Dtos;
using MusteriPaneli.Entities;
using MusteriPaneli.Enums;
using MusteriPaneli.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.ObjectMapping;

namespace MusteriPaneli.Services
{
    public class TurService : ApplicationService, ITurService
    {
        private readonly ITurRepository _repository;
        public TurService(ITurRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<TurDto<TelefonTuru>>> GetTelefonTurleriAsync()
        {
            var data = await _repository.GetTelefonTurleriAsync();
            if (data != null)
            {
                var dtoList = new List<TurDto<TelefonTuru>>();
                foreach (var entry in data)
                {
                    dtoList.Add(ObjectMapper.Map<Tur<TelefonTuru, Telefon>, TurDto<TelefonTuru>>(entry));
                }
                return dtoList;
            }
            else
                return null;
        }
        public async Task<List<TurDto<AdresTuru>>> GetAdresTurleriAsync()
        {
            var data = await _repository.GetAdresTurleriAsync();
            if (data != null)
            {
                var dtoList = new List<TurDto<AdresTuru>>();
                foreach (var entry in data)
                {
                    dtoList.Add(ObjectMapper.Map<Tur<AdresTuru, Adres>, TurDto<AdresTuru>>(entry));
                }
                return dtoList;
            }
            else
                return null;
        }
        public async Task<List<TurDto<OdemeTuru>>> GetOdemeTurleriAsync()
        {
            var data = await _repository.GetOdemeTurleriAsync();
            if (data != null)
            {
                var dtoList = new List<TurDto<OdemeTuru>>();
                foreach (var entry in data)
                {
                    dtoList.Add(ObjectMapper.Map<Tur<OdemeTuru, OdemeMusteri>, TurDto<OdemeTuru>>(entry));
                }
                return dtoList;
            }
            else
                return null;
        }
    }
}
