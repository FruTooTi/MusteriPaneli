using MusteriPaneli.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace MusteriPaneli.Entities
{
    public class OdemeMusteri
    {
        public Guid MusteriId { get; set; }
        public int OdemeId { get; set; }
        public Tur<OdemeTuru, OdemeMusteri> Odeme { get; set; }
        public Musteri Musteri { get; set; }
    }
}
