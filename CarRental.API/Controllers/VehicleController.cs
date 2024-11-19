using Microsoft.AspNetCore.Mvc;
using CarRental.Domain;
using System.Collections.Generic;
using System.Linq;
using CarRental.API.Services;
using CarRental.API.DTO;
namespace CarRental.Api.Controllers;

/// <summary>
/// Контроллер для работы с автомобилями
/// </summary>
/// <param name="vehicleService">Сервис для работы с автомобилями</param>
[ApiController]
[Route("api/[controller]")]
public class VehiclesController(IService<VehicleDTO,Vehicle> vehicleService) : ControllerBase
{

    /// <summary>
    /// Получить все автомобили
    /// </summary>
    /// <returns>Список автомобилей</returns>
    [HttpGet]
    public ActionResult<IEnumerable<VehicleDTO>> GetAll()
    {
        return Ok(vehicleService.GetAll());
    }

    /// <summary>
    /// Получить автомобиль по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор автомобиля</param>
    /// <returns>Автомобиль</returns>
    [HttpGet("{id}")]
    public ActionResult<VehicleDTO> Get(int id)
    {
        var result = vehicleService.Get(id);
        if (result == null)
            return NotFound();

        return Ok(result);
    }

    /// <summary>
    /// Создать новый автомобиль
    /// </summary>
    /// <param name="vehicle">Данные автомобиля</param>
    /// <returns>Созданный автомобиль</returns>
    [HttpPost]
    public ActionResult<VehicleDTO> Post([FromBody] VehicleDTO vehicle)
    {
        var result = vehicleService.Post(vehicle);
        if (result == null)
            return BadRequest();

        return Ok(result);
    }

    /// <summary>
    /// Обновить существующий автомобиль
    /// </summary>
    /// <param name="id">Идентификатор автомобиля</param>
    /// <param name="vehicle">Обновленные данные автомобиля</param>
    /// <returns>Статус ответа</returns>
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] VehicleDTO vehicle)
    {
        var result = vehicleService.Put(id, vehicle);
        if (!result)
            return BadRequest();

        return Ok();
    }

    /// <summary>
    /// Удалить автомобиль по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор автомобиля</param>
    /// <returns>Статус ответа</returns>
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var result = vehicleService.Delete(id);
        if (!result)
            return NotFound();

        return Ok();
    }
}