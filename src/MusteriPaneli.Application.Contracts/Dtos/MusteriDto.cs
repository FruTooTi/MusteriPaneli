using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MusteriPaneli.Dtos
{
    public class MusteriDto : EntityDto<Guid>
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TC { get; set; }
        public bool SiradisiMi { get; set; }
        public List<IletisimDto> Iletisim { get; set; }
        public List<AdresDto> Adres { get; set; }
        public List<OdemeDto>? Odeme { get; set; }
    }
}
