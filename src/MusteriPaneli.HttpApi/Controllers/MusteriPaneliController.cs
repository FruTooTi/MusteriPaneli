using Microsoft.AspNetCore.Mvc;
using MusteriPaneli.Dtos;
using MusteriPaneli.Interfaces;
using MusteriPaneli.Localization;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace MusteriPaneli.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MusteriPaneliController : AbpControllerBase
{
    protected MusteriPaneliController()
    {
        LocalizationResource = typeof(MusteriPaneliResource);
    }
}
[ApiController]
[Route("api/[Controller]")]
public class MusteriController : MusteriPaneliController, IMusteriService
{
    public IMusteriService _service { get; set; }
    public MusteriController(IMusteriService service)
    {
        _service = service;
    }
    [HttpDelete("{id}")]
    public async Task<MusteriDto> DeleteAsync(Guid id)
    {
        return await _service.DeleteAsync(id);
    }
    [HttpGet]
    public async Task<List<MusteriDto>> GetAllAsync()
    {
        return await _service.GetAllAsync();
    }
    [HttpGet("{id}")]
    public async Task<MusteriDto> GetAsync(Guid id)
    {
        return await _service.GetAsync(id);
    }
    [HttpPost]
    public async Task<CreateOrUpdateMusteriDto> InsertAsync(CreateOrUpdateMusteriDto input)
    {
        return await _service.InsertAsync(input);
    }
    [HttpPut("{id}")]
    public async Task<CreateOrUpdateMusteriDto> UpdateAsync(Guid id, CreateOrUpdateMusteriDto input)
    {
        return await _service.UpdateAsync(id, input);
    }
}
