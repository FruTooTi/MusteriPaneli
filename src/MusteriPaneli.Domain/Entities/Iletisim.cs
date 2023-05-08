using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Guids;

namespace MusteriPaneli.Entities
{
    public class Iletisim : BasicAggregateRoot<Guid>
    {
        //public Iletisim(Guid id)
        //{
        //    Id = id;
        //}
        public string Email { get; set; }
        public List<Telefon> Telefon { get; set; }
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
