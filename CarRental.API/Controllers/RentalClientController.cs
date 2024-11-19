using CarRental.API.DTO;
using CarRental.API.Services;
using CarRental.Domain;
using Microsoft.AspNetCore.Mvc;
namespace CarRental.Api.Controllers;

/// <summary>
/// Контроллер для управления клиентами
/// </summary>
/// <param name="rentalClientService">Сервис для работы с клиентами</param>
[ApiController]
[Route("api/[controller]")]
public class RentalClientsController(IService<RentalClientDTO, RentalClient> rentalClientService) : ControllerBase
{

    /// <summary>
    /// Получить всех клиентов проката
    /// </summary>
    /// <returns>Список клиентов проката</returns>
    [HttpGet]
    public ActionResult<IEnumerable<RentalClientDTO>> GetAll()
    {
        return Ok(rentalClientService.GetAll());
    }

    /// <summary>
    /// Получить клиента проката по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор клиента</param>
    /// <returns>Клиент проката</returns>
    [HttpGet("{id}")]
    public ActionResult<RentalClientDTO> Get(int id)
    {
        var result = rentalClientService.Get(id);
        if (result == null)
            return NotFound();

        return Ok(result);
    }

    /// <summary>
    /// Создать нового клиента проката
    /// </summary>
    /// <param name="rentalClient">Данные клиента проката</param>
    /// <returns>Созданный клиент проката</returns>
    [HttpPost]
    public ActionResult<RentalClientDTO> Post([FromBody] RentalClientDTO rentalClient)
    {
        var result = rentalClientService.Post(rentalClient);
        if (result == null)
            return BadRequest();

        return Ok(result);
    }

    /// <summary>
    /// Обновить существующего клиента проката
    /// </summary>
    /// <param name="id">Идентификатор клиента</param>
    /// <param name="rentalClient">Обновленные данные клиента проката</param>
    /// <returns>Статус ответа</returns>
    [HttpPut("{id}")]
    public IActionResult Put(int id,[FromBody] RentalClientDTO rentalClient)
    {
        var result = rentalClientService.Put(id, rentalClient);
        if (!result)
            return BadRequest();

        return Ok();
    }

    /// <summary>
    /// Удалить клиента проката по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор клиента</param>
    /// <returns>Статус ответа</returns>
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var result = rentalClientService.Delete(id);
        if (!result)
            return NotFound();

        return Ok();
    }
}