using CarRental.Domain;
using Microsoft.AspNetCore.Mvc;
namespace CarRental.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarOnRentController : ControllerBase
{
    private static List<CarOnRent> carRentals = new List<CarOnRent>();

    /// <summary>
    /// Получить все аренды автомобилей
    /// </summary>
    /// <returns>Список аренд автомобилей</returns>
    [HttpGet]
    public ActionResult<IEnumerable<CarOnRent>> GetAll()
    {
        return Ok(carRentals);
    }

    /// <summary>
    /// Получить аренду автомобиля по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор аренды</param>
    /// <returns>Аренда автомобиля</returns>
    [HttpGet("{id}")]
    public ActionResult<CarOnRent> GetById(int id)
    {
        var rental = carRentals.FirstOrDefault(r => r.Id == id);
        if (rental == null)
        {
            return NotFound();
        }
        return Ok(rental);
    }

    /// <summary>
    /// Создать новую аренду автомобиля
    /// </summary>
    /// <param name="carOnRent">Данные аренды автомобиля</param>
    /// <returns>Созданная аренда автомобиля</returns>
    [HttpPost]
    public ActionResult<CarOnRent> Create(CarOnRent carOnRent)
    {
        carOnRent.Id = carRentals.Count > 0 ? carRentals.Max(r => r.Id) + 1 : 1; // Генерация уникального ID
        carRentals.Add(carOnRent);
        return CreatedAtAction(nameof(GetById), new { id = carOnRent.Id }, carOnRent);
    }

    /// <summary>
    /// Обновить существующую аренду автомобиля
    /// </summary>
    /// <param name="id">Идентификатор аренды</param>
    /// <param name="carOnRent">Обновленные данные аренды автомобиля</param>
    /// <returns>Статус ответа</returns>
    [HttpPut("{id}")]
    public IActionResult Update(int id, CarOnRent carOnRent)
    {
        var existingRental = carRentals.FirstOrDefault(r => r.Id == id);
        if (existingRental == null)
        {
            return NotFound();
        }
        existingRental.Vehicle = carOnRent.Vehicle;
        existingRental.Client = carOnRent.Client;
        existingRental.RentalPointGetFrom = carOnRent.RentalPointGetFrom;
        existingRental.RentalTime = carOnRent.RentalTime;
        existingRental.RentalDuration = carOnRent.RentalDuration;
        existingRental.ReturnTime = carOnRent.ReturnTime;
        existingRental.RentalPointReturnTo = carOnRent.RentalPointReturnTo;
        return NoContent();
    }

    /// <summary>
    /// Удалить аренду автомобиля по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор аренды</param>
    /// <returns>Статус ответа</returns>
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var rental = carRentals.FirstOrDefault(r => r.Id == id);
        if (rental == null)
        {
            return NotFound();
        }
        carRentals.Remove(rental);
        return NoContent();
    }
}