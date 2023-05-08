using AutoMapper;
using AutoMapper.EquivalencyExpression;
using MusteriPaneli.Dtos;
using MusteriPaneli.Entities;
using MusteriPaneli.Interfaces;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;
using Volo.Abp.ObjectMapping;
using Volo.Abp.Uow;

namespace MusteriPaneli.Services
{
    public class MusteriService : ApplicationService, IMusteriService
    {
        private readonly IMusteriRepository _repository;
        private readonly IGuidGenerator _guidGenerator;
        private readonly IMapper _mapper;
        public MusteriService(IMusteriRepository repository, IGuidGenerator guidGenerator, IMapper mapper)
        {
            _repository = repository;
            _guidGenerator = guidGenerator;
            _mapper = mapper;
        }
        public async Task<List<MusteriDto>> GetAllAsync()
        {
            var data = await _repository.WithDetailsAsync();
            
            if (data != null)
            {
                var result = new List<MusteriDto>();
                foreach (var entry in data)
                {
                    result.Add(ObjectMapper.Map<Musteri, MusteriDto>(entry));
                }
                return result;
            }
            return null;
        }
        public async Task<MusteriDto> GetAsync(Guid id)
        {
            var data = await _repository.GetAsync(id, true);
            if (data != null)
                return ObjectMapper.Map<Musteri, MusteriDto>(data);
            return null;
        }
        public async Task<CreateOrUpdateMusteriDto> InsertAsync(CreateOrUpdateMusteriDto input)
        {
            if (input != null)
            {
                var newMusteri = ObjectMapper.Map<CreateOrUpdateMusteriDto, Musteri>(input);
                await _repository.InsertAsync(newMusteri);
                CheckSiradisiMi(newMusteri);
                return input;
            }
            return null;
        }
        public async Task<CreateOrUpdateMusteriDto> UpdateAsync(Guid id, CreateOrUpdateMusteriDto input)
        {
            var target = await _repository.GetAsync(id, true);
            if (target != null)
            {
                ObjectMapper.Map(input, target);
                await _repository.UpdateAsync(target);
                CheckSiradisiMi(target);
                return input;
            }
            return null;
        }
        public async Task<MusteriDto> DeleteAsync(Guid id)
        {
            var target = await _repository.GetAsync(id, true);
            if (target != null)
            {
                await _repository.DeleteAsync(target, true);
                return ObjectMapper.Map<Musteri, MusteriDto>(target);
            }
            return null;
        }
        private Musteri CheckSiradisiMi(Musteri newMusteri)
        {
            var isimLowerCase = newMusteri.Isim.ToLower();
            List<char> sesli = new List<char>() { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            foreach (char c in isimLowerCase)
            {
                if (sesli.Contains(c) && isimLowerCase.Count(harf => harf == c) >= 3)
                {
                    newMusteri.SiradisiMi = true;
                    return newMusteri;
                }
            }
            newMusteri.SiradisiMi = false;
            return newMusteri;
        }

        //private Musteri TrySetGuid(CreateOrUpdateMusteriDto newMusteri, Musteri? musteri)
        //{
        //    if (musteri == null)
        //    {
        //        musteri = new Musteri(_guidGenerator.Create());
        //        musteri.Adres = new List<Adres>();
        //        musteri.Iletisim = new List<Iletisim>();
        //    }
        //    foreach (var adresdto in newMusteri.Adres)
        //    {
        //        if(adresdto.Id == null)
        //            musteri.Adres.Add(new Adres(_guidGenerator.Create()));
        //    }
        //    foreach (var iletisimdto in newMusteri.Iletisim)
        //    {
        //        if(iletisimdto.Id == null)
        //        {
        //            Iletisim iletisim = new Iletisim(_guidGenerator.Create());
        //            iletisim.Telefon = new List<Telefon>();
        //            foreach (var telefondto in iletisimdto.Telefon)
        //            {
        //                if(telefondto.Id == null)
        //                    iletisim.Telefon.Add(new Telefon(_guidGenerator.Create()));
        //            }
        //            musteri.Iletisim.Add(iletisim);
        //        }
        //    }
        //    return musteri;
        //}
    }
}
