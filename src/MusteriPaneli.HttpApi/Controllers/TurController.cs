using Microsoft.AspNetCore.Mvc;
using MusteriPaneli.Dtos;
using MusteriPaneli.Enums;
using MusteriPaneli.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriPaneli.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TurController : MusteriPaneliController, ITurService
    {
        private readonly ITurService _service;
        public TurController(ITurService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("adres")]
        public async Task<List<TurDto<AdresTuru>>> GetAdresTurleriAsync()
        {
            return await _service.GetAdresTurleriAsync();
        }
        [HttpGet]
        [Route("odeme")]
        public async Task<List<TurDto<OdemeTuru>>> GetOdemeTurleriAsync()
        {
            return await _service.GetOdemeTurleriAsync();
        }
        [HttpGet]
        [Route("telefon")]
        public async Task<List<TurDto<TelefonTuru>>> GetTelefonTurleriAsync()
        {
            return await _service.GetTelefonTurleriAsync();
        }
    }
}
