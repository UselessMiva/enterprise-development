using CarRental.API.DTO;
using CarRental.API.Services;
using CarRental.Domain;
using Microsoft.AspNetCore.Mvc;
namespace CarRental.Api.Controllers;

/// <summary>
/// Контроллер для управления автомобилями в аренде
/// </summary>
/// <param name="carOnRentService">Сервис для работы с автомобилями в аренде</param>
[ApiController]
[Route("api/[controller]")]
public class CarOnRentController(IService<CarOnRentDTO, CarOnRent> carOnRentService) : ControllerBase
{

    /// <summary>
    /// Получить все аренды автомобилей
    /// </summary>
    /// <returns>Список аренд автомобилей</returns>
    [HttpGet]
    public ActionResult<IEnumerable<CarOnRentDTO>> GetAll()
    {
        return Ok(carOnRentService.GetAll());
    }

    /// <summary>
    /// Получить аренду автомобиля по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор аренды</param>
    /// <returns>Аренда автомобиля</returns>
    [HttpGet("{id}")]
    public ActionResult<CarOnRentDTO> Get(int id)
    {
        var result = carOnRentService.Get(id);
        if (result == null)
            return NotFound();

        return Ok(result);
    }

    /// <summary>
    /// Создать новую аренду автомобиля
    /// </summary>
    /// <param name="carOnRent">Данные аренды автомобиля</param>
    /// <returns>Созданная аренда автомобиля</returns>
    [HttpPost]
    public ActionResult<CarOnRentDTO> Create([FromBody] CarOnRentDTO carOnRent)
    {
        var result = carOnRentService.Post(carOnRent);
        if (result == null)
            return BadRequest();

        return Ok(result);
    }

    /// <summary>
    /// Обновить существующую аренду автомобиля
    /// </summary>
    /// <param name="id">Идентификатор аренды</param>
    /// <param name="carOnRent">Обновленные данные аренды автомобиля</param>
    /// <returns>Статус ответа</returns>
    [HttpPut("{id}")]
    public IActionResult Put(int id,[FromBody] CarOnRentDTO carOnRent)
    {
        var result = carOnRentService.Put(id, carOnRent);
        if (!result)
            return BadRequest();

        return Ok();
    }

    /// <summary>
    /// Удалить аренду автомобиля по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор аренды</param>
    /// <returns>Статус ответа</returns>
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var result = carOnRentService.Delete(id);
        if (!result)
            return NotFound();

        return Ok();
    }
}