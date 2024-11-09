using CarRental.Domain;
using Microsoft.AspNetCore.Mvc;
namespace CarRental.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RentalPointsController : ControllerBase
{
    private static List<RentalPoint> rentalPoints = new List<RentalPoint>();

    /// <summary>
    /// Получить все пункты проката
    /// </summary>
    /// <returns>Список пунктов проката</returns>
    [HttpGet]
    public ActionResult<IEnumerable<RentalPoint>> GetAll()
    {
        return Ok(rentalPoints);
    }

    /// <summary>
    /// Получить пункт проката по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор пункта проката</param>
    /// <returns>Пункт проката</returns>
    [HttpGet("{id}")]
    public ActionResult<RentalPoint> GetById(int id)
    {
        var rentalPoint = rentalPoints.FirstOrDefault(r => r.Id == id);
        if (rentalPoint == null)
        {
            return NotFound();
        }
        return Ok(rentalPoint);
    }

    /// <summary>
    /// Создать новый пункт проката
    /// </summary>
    /// <param name="rentalPoint">Данные пункта проката</param>
    /// <returns>Созданный пункт проката</returns>
    [HttpPost]
    public ActionResult<RentalPoint> Create(RentalPoint rentalPoint)
    {
        rentalPoint.Id = rentalPoints.Count > 0 ? rentalPoints.Max(r => r.Id) + 1 : 1; // Генерация уникального ID
        rentalPoints.Add(rentalPoint);
        return CreatedAtAction(nameof(GetById), new { id = rentalPoint.Id }, rentalPoint);
    }

    /// <summary>
    /// Обновить существующий пункт проката
    /// </summary>
    /// <param name="id">Идентификатор пункта проката</param>
    /// <param name="rentalPoint">Обновленные данные пункта проката</param>
    /// <returns>Статус ответа</returns>
    [HttpPut("{id}")]
    public IActionResult Update(int id, RentalPoint rentalPoint)
    {
        var existingRentalPoint = rentalPoints.FirstOrDefault(r => r.Id == id);
        if (existingRentalPoint == null)
        {
            return NotFound();
        }
        existingRentalPoint.Name = rentalPoint.Name;
        existingRentalPoint.Address = rentalPoint.Address;
        return NoContent();
    }

    /// <summary>
    /// Удалить пункт проката по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор пункта проката</param>
    /// <returns>Статус ответа</returns>
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var rentalPoint = rentalPoints.FirstOrDefault(r => r.Id == id);
        if (rentalPoint == null)
        {
            return NotFound();
        }
        rentalPoints.Remove(rentalPoint);
        return NoContent();
    }
}
