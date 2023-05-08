using MusteriPaneli.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace MusteriPaneli.Interfaces
{
    public interface IMusteriRepository : IRepository<Musteri, Guid>
    {
    }
}
