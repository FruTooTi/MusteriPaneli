using MusteriPaneli.Entities;
using MusteriPaneli.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace MusteriPaneli.DbMigrator.Seeder
{
    public class DbContextDataSeeder : ITransientDependency, IDataSeedContributor
    {
        public IRepository<Tur<OdemeTuru, OdemeMusteri>, int> _repositoryOdemeTuru { get; set; }
        public IRepository<Tur<AdresTuru, Adres>, int> _repositoryAdresTuru { get; set; }
        public IRepository<Tur<TelefonTuru, Telefon>, int> _repositoryTelefonTuru { get; set; }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _repositoryOdemeTuru.CountAsync() <= 0)
            {
                foreach (var val in Enum.GetValues(typeof(OdemeTuru)))
                {
                    var element = new Tur<OdemeTuru, OdemeMusteri>()
                    {
                        Aciklama = val.ToString()
                    };
                    await _repositoryOdemeTuru.InsertAsync(element);
                }
            }
            if (await _repositoryAdresTuru.CountAsync() <= 0)
            {
                foreach (var val in Enum.GetValues(typeof(AdresTuru)))
                {
                    var element = new Tur<AdresTuru, Adres>()
                    {
                        Aciklama = val.ToString()
                    };
                    await _repositoryAdresTuru.InsertAsync(element);
                }
            }
            if (await _repositoryTelefonTuru.CountAsync() <= 0)
            {
                foreach (var val in Enum.GetValues(typeof(TelefonTuru)))
                {
                    var element = new Tur<TelefonTuru, Telefon>()
                    {
                        Aciklama = val.ToString()
                    };
                    await _repositoryTelefonTuru.InsertAsync(element);
                }
            }
        }
    }
}
