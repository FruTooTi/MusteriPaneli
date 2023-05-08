using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MusteriPaneli.Dtos
{
    public class TurDto<T> : EntityDto<int> where T : System.Enum
    {
        public string Aciklama { get; set; }
    }
}
