using Microsoft.EntityFrameworkCore;
using MusteriPaneli.Entities;
using MusteriPaneli.EntityFrameworkCore;
using MusteriPaneli.Enums;
using MusteriPaneli.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriPaneli.Repositories
{
    public class TurRepository : ITurRepository
    {
        private readonly MusteriPaneliDbContext _context;
        public TurRepository(MusteriPaneliDbContext context)
        {
            _context = context;
        }
    public async Task<List<Tur<TelefonTuru, Telefon>>> GetTelefonTurleriAsync()
    {
        return await _context.telefonturleri.ToListAsync();
    }
    public async Task<List<Tur<AdresTuru, Adres>>> GetAdresTurleriAsync()
    {
        return await _context.adresturleri.ToListAsync();
    }
    public async Task<List<Tur<OdemeTuru, OdemeMusteri>>> GetOdemeTurleriAsync()
    {
        return await _context.odemeturleri.ToListAsync();
    }
}
}
