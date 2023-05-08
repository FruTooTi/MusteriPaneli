using Microsoft.EntityFrameworkCore.ChangeTracking;
using MusteriPaneli.Entities;
using MusteriPaneli.EntityFrameworkCore;
using MusteriPaneli.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace MusteriPaneli.Repositories
{
    public class MusteriRepository: EfCoreRepository<MusteriPaneliDbContext, Musteri, Guid>, IMusteriRepository
    {
        public MusteriRepository(IDbContextProvider<MusteriPaneliDbContext> context): base(context) 
        { 
        }
        //public async override Task<Musteri> InsertAsync(Musteri entity, bool autoSave = false, CancellationToken cancellationToken = default)
        //{
        //    foreach (var adres in entity.Adres)
        //    {
        //        base.TrySetGuidId(adres);
        //    }
        //    foreach (var iletisim in entity.Iletisim)
        //    {
        //        foreach (var telefon in iletisim.Telefon)
        //        {
        //            base.TrySetGuidId(telefon);
        //        }
        //        base.TrySetGuidId(iletisim);
        //    }
        //    await base.InsertAsync(entity, autoSave, cancellationToken);
        //    return entity;
        //}
        public async override Task<Musteri> UpdateAsync(Musteri entity, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            foreach (var adres in entity.Adres)
            {
                base.TrySetGuidId(adres);
            }
            foreach (var iletisim in entity.Iletisim)
            {
                foreach (var telefon in iletisim.Telefon)
                {
                    base.TrySetGuidId(telefon);
                }
                base.TrySetGuidId(iletisim);
            }
            await base.UpdateAsync(entity, autoSave, cancellationToken);
            return entity;
        }
    }
}
