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
    public class Adres : BasicAggregateRoot<Guid>
    {
        public Adres(Guid id)
        {
            Id = id;
        }
        public int TurId { get; set; }
        public Tur<AdresTuru, Adres> Tur { get; set; }
        public string Aciklama { get; set; }
        public Musteri Musteri { get; set; }

        public void SetIdIfEmpty()
        {
            if (Id == Guid.Empty)
            {
                Id = new SimpleGuidGenerator().Create();
            }
        }
    }
}
