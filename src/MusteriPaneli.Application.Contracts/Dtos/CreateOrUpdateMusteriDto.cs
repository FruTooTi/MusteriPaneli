using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriPaneli.Dtos
{
    public class CreateOrUpdateMusteriDto
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TC { get; set; }
        public List<IletisimDto> Iletisim { get; set; }
        public List<AdresDto> Adres { get; set; }
        public List<OdemeDto>? Odeme { get; set; }
    }
}
