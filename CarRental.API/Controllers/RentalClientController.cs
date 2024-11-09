using CarRental.Domain;
using Microsoft.AspNetCore.Mvc;
namespace CarRental.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RentalClientsController : ControllerBase
{
    private static List<RentalClient> rentalClients = new List<RentalClient>();

    /// <summary>
    /// Получить всех клиентов проката
    /// </summary>
    /// <returns>Список клиентов проката</returns>
    [HttpGet]
    public ActionResult<IEnumerable<RentalClient>> GetAll()
    {
        return Ok(rentalClients);
    }

    /// <summary>
    /// Получить клиента проката по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор клиента</param>
    /// <returns>Клиент проката</returns>
    [HttpGet("{id}")]
    public ActionResult<RentalClient> GetById(int id)
    {
        var rentalClient = rentalClients.FirstOrDefault(c => c.Id == id);
        if (rentalClient == null)
        {
            return NotFound();
        }
        return Ok(rentalClient);
    }

    /// <summary>
    /// Создать нового клиента проката
    /// </summary>
    /// <param name="rentalClient">Данные клиента проката</param>
    /// <returns>Созданный клиент проката</returns>
    [HttpPost]
    public ActionResult<RentalClient> Create(RentalClient rentalClient)
    {
        rentalClient.Id = rentalClients.Count > 0 ? rentalClients.Max(c => c.Id) + 1 : 1; // Генерация уникального ID
        rentalClients.Add(rentalClient);
        return CreatedAtAction(nameof(GetById), new { id = rentalClient.Id }, rentalClient);
    }

    /// <summary>
    /// Обновить существующего клиента проката
    /// </summary>
    /// <param name="id">Идентификатор клиента</param>
    /// <param name="rentalClient">Обновленные данные клиента проката</param>
    /// <returns>Статус ответа</returns>
    [HttpPut("{id}")]
    public IActionResult Update(int id, RentalClient rentalClient)
    {
        var existingRentalClient = rentalClients.FirstOrDefault(c => c.Id == id);
        if (existingRentalClient == null)
        {
            return NotFound();
        }
        existingRentalClient.Passport = rentalClient.Passport;
        existingRentalClient.FullName = rentalClient.FullName;
        existingRentalClient.BirthDate = rentalClient.BirthDate;
        return NoContent();
    }

    /// <summary>
    /// Удалить клиента проката по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор клиента</param>
    /// <returns>Статус ответа</returns>
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var rentalClient = rentalClients.FirstOrDefault(c => c.Id == id);
        if (rentalClient == null)
        {
            return NotFound();
        }
        rentalClients.Remove(rentalClient);
        return NoContent();
    }
}