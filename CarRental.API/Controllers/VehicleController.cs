using Microsoft.AspNetCore.Mvc;
using CarRental.Domain;
using System.Collections.Generic;
using System.Linq;
namespace CarRental.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VehiclesController : ControllerBase
{
    private static List<Vehicle> vehicles = new List<Vehicle>();

    /// <summary>
    /// Получить все автомобили
    /// </summary>
    /// <returns>Список автомобилей</returns>
    [HttpGet]
    public ActionResult<IEnumerable<Vehicle>> GetAll()
    {
        return Ok(vehicles);
    }

    /// <summary>
    /// Получить автомобиль по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор автомобиля</param>
    /// <returns>Автомобиль</returns>
    [HttpGet("{id}")]
    public ActionResult<Vehicle> GetById(int id)
    {
        var vehicle = vehicles.FirstOrDefault(v => v.Id == id);
        if (vehicle == null)
        {
            return NotFound();
        }
        return Ok(vehicle);
    }

    /// <summary>
    /// Создать новый автомобиль
    /// </summary>
    /// <param name="vehicle">Данные автомобиля</param>
    /// <returns>Созданный автомобиль</returns>
    [HttpPost]
    public ActionResult<Vehicle> Create(Vehicle vehicle)
    {
        vehicle.Id = vehicles.Count > 0 ? vehicles.Max(v => v.Id) + 1 : 1;
        vehicles.Add(vehicle);
        return CreatedAtAction(nameof(GetById), new { id = vehicle.Id }, vehicle);
    }

    /// <summary>
    /// Обновить существующий автомобиль
    /// </summary>
    /// <param name="id">Идентификатор автомобиля</param>
    /// <param name="vehicle">Обновленные данные автомобиля</param>
    /// <returns>Статус ответа</returns>
    [HttpPut("{id}")]
    public IActionResult Update(int id, Vehicle vehicle)
    {
        var existingVehicle = vehicles.FirstOrDefault(v => v.Id == id);
        if (existingVehicle == null)
        {
            return NotFound();
        }

        existingVehicle.CarNumber = vehicle.CarNumber;
        existingVehicle.Model = vehicle.Model;
        existingVehicle.Color = vehicle.Color;

        return NoContent();
    }

    /// <summary>
    /// Удалить автомобиль по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор автомобиля</param>
    /// <returns>Статус ответа</returns>
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var vehicle = vehicles.FirstOrDefault(v => v.Id == id);
        if (vehicle == null)
        {
            return NotFound();
        }

        vehicles.Remove(vehicle);
        return NoContent();
    }
}