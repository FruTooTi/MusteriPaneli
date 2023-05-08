using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MusteriPaneli.Dtos
{
    public class IletisimDto
    {
        public string Email { get; set; }
        public List<TelefonDto> Telefon { get; set; }
        [DefaultValue(null)]
        public Guid? Id { get; set; }
    }
}
