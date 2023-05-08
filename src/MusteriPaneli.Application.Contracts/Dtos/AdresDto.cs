using MusteriPaneli.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MusteriPaneli.Dtos
{
    public class AdresDto
    {
        public int Tur { get; set; }
        public string? TurAciklamasi { get; private set; } // Çok Çok Önemli!!!
        public string Aciklama { get; set; }
        [DefaultValue(null)]
        public Guid? Id { get; set; }
    }
}
