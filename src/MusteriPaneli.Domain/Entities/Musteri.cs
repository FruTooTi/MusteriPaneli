using Microsoft.EntityFrameworkCore;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Guids;

namespace MusteriPaneli.Entities
{
    public class Musteri : AuditedAggregateRoot<Guid>
    {
        public Musteri(Guid id)
        {
            Id = id;
        }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TC { get; set; }
        public List<Iletisim> Iletisim { get; set; }
        public List<Adres> Adres { get; set; }
        public List<OdemeMusteri>? Odeme { get; set; }
        public bool SiradisiMi { get; set; }

        public void SetIdIfEmpty()
        {
            if (Id == Guid.Empty)
            {
                Id = new SimpleGuidGenerator().Create();
            }
        }
    }
}
