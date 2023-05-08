using MusteriPaneli.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Guids;

namespace MusteriPaneli.Entities
{
    public class Telefon : BasicAggregateRoot<Guid>
    {
        public Telefon(Guid id)
        {
            Id = id;
        }
        public int TurId { get; set; }
        public Tur<TelefonTuru, Telefon>? Tur { get; set; }
        public string Numara { get; set; }
        public Iletisim Iletisim { get; set; }

        public void SetIdIfEmpty()
        {
            if (Id == Guid.Empty)
            {
                Id = new SimpleGuidGenerator().Create();
            }
        }
    }
}
