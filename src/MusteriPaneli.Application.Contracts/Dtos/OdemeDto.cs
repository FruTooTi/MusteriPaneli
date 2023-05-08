using MusteriPaneli.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriPaneli.Dtos
{
    public class OdemeDto
    {
        public int OdemeId { get; set; }
        public string? TurAciklamasi { get; private set; } // Çok Çok Önemli!!!
    }
}
