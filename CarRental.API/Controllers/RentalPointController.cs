using CarRental.API.DTO;
using CarRental.API.Services;
using CarRental.Domain;
using Microsoft.AspNetCore.Mvc;
namespace CarRental.Api.Controllers;

/// <summary>
/// Контроллер для управления точками проката
/// </summary>
/// <param name="rentalPointService">Сервис для работы с точками проката</param>
[ApiController]
[Route("api/[controller]")]
public class RentalPointsController(IService<RentalPointGetDTO, RentalPointPostDTO> rentalPointService) : ControllerBase
{

    /// <summary>
    /// Получить все пункты проката
    /// </summary>
    /// <returns>Список пунктов проката</returns>
    [HttpGet]
    public ActionResult<IEnumerable<RentalPointGetDTO>> GetAll()
    {
        return Ok(rentalPointService.GetAll());
    }

    /// <summary>
    /// Получить пункт проката по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор пункта проката</param>
    /// <returns>Пункт проката</returns>
    [HttpGet("{id}")]
    public ActionResult<RentalPointGetDTO> Get(int id)
    {
        var result = rentalPointService.Get(id);
        if (result == null)
            return NotFound();

        return Ok(result);
    }

    /// <summary>
    /// Создать новый пункт проката
    /// </summary>
    /// <param name="rentalPoint">Данные пункта проката</param>
    /// <returns>Созданный пункт проката</returns>
    [HttpPost]
    public ActionResult<RentalPointGetDTO> Post([FromBody] RentalPointPostDTO rentalPoint)
    {
        var result = rentalPointService.Post(rentalPoint);
        if (result == null)
            return BadRequest();

        return Ok(result);
    }

    /// <summary>
    /// Обновить существующий пункт проката
    /// </summary>
    /// <param name="id">Идентификатор пункта проката</param>
    /// <param name="rentalPoint">Обновленные данные пункта проката</param>
    /// <returns>Статус ответа</returns>
    [HttpPut("{id}")]
    public IActionResult Put(int id,[FromBody] RentalPointPostDTO rentalPoint)
    {
        var result = rentalPointService.Put(id, rentalPoint);
        if (!result)
            return BadRequest();

        return Ok();
    }

    /// <summary>
    /// Удалить пункт проката по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор пункта проката</param>
    /// <returns>Статус ответа</returns>
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var result = rentalPointService.Delete(id);
        if (!result)
            return NotFound();

        return Ok();
    }
}
