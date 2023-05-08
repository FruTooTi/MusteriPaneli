using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace MusteriPaneli.Entities
{
    public class Tur<T, K> : Entity<int> where T : System.Enum
                            where K : class
    {
        public string Aciklama { get; set; }
        public List<K> SatirId { get; set; }
    }
}
