using AutoMapper;
using AutoMapper.Collection;
using AutoMapper.EquivalencyExpression;
using MusteriPaneli.Dtos;
using MusteriPaneli.Entities;
using MusteriPaneli.Enums;
using System;
using Volo.Abp.Guids;
using Volo.Abp.ObjectMapping;

namespace MusteriPaneli;

public class MusteriPaneliApplicationAutoMapperProfile : Profile
{
    public int Config1 { get; set; }
    public MusteriPaneliApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<OdemeMusteri, OdemeMusteri>();

        CreateMap<IletisimDto, Iletisim>();

        CreateMap<TelefonDto, Telefon>()
            .ForMember(p => p.TurId, k => k.MapFrom(l => l.Tur))
            .ForMember(p => p.Tur, opt => opt.Ignore());

        CreateMap<AdresDto, Adres>()
            .ForMember(p => p.TurId, k => k.MapFrom(l => l.Tur))
            .ForMember(p => p.Tur, opt => opt.Ignore());

        CreateMap<OdemeDto, OdemeMusteri>();

        CreateMap<CreateOrUpdateMusteriDto, Musteri>();

        CreateMap<Iletisim, IletisimDto>();

        CreateMap<Telefon, TelefonDto>()
            .ForMember(p => p.Tur, k => k.MapFrom(l => l.TurId))
            .ForMember(p => p.TurAciklamasi, opt => opt.MapFrom(l => l.Tur.Aciklama));

        CreateMap<Adres, AdresDto>()
            .ForMember(p => p.Tur, k => k.MapFrom(l => l.TurId))
            .ForMember(p => p.TurAciklamasi, opt => opt.MapFrom(l => l.Tur.Aciklama));

        CreateMap<OdemeMusteri, OdemeDto>()
            .ForMember(p => p.TurAciklamasi, opt => opt.MapFrom(l => l.Odeme.Aciklama));

        CreateMap<Musteri, MusteriDto>();

        CreateMap<Tur<TelefonTuru, Telefon>, TurDto<TelefonTuru>>();
        CreateMap<Tur<AdresTuru, Adres>, TurDto<AdresTuru>>();
        CreateMap<Tur<OdemeTuru, OdemeMusteri>, TurDto<OdemeTuru>>();
    }
}
