using CarRental.API.DTO;
using CarRental.API.Services;
using CarRental.Domain;
using Microsoft.AspNetCore.Mvc;
namespace CarRental.API.Controllers;

/// <summary>
/// Контроллер для работы с запросами
/// </summary>
/// <param name="requestService">Сервис для запросов</param>
[Route("api/[controller]")]
[ApiController]
public class RequestController(IRequestService requestService) : ControllerBase
{

    /// <summary>
    /// Возвращает список всех автомобилей
    /// </summary>
    /// <returns>Список автомобилей</returns>
    [HttpGet("allVehciles")]
    public ActionResult<List<VehicleGetDTO>> GetAllVehciles()
    {
        var vehicles = requestService.ReturnAllCars();
        return Ok(vehicles);
    }

    /// <summary>
    /// Возвращает список клиентов, арендовавших автомобиль определённой модели
    /// </summary>
    /// <returns>Список клиентов, арендовавших автомобиль определённой модели</returns>
    [HttpGet("clientsWhoRented")]
    public ActionResult<List<VehicleGetDTO>> GetClientsWhoRentedCarOfTheSpecialModel(string modelToSearch)
    {
        var vehicles = requestService.ClientsWhoRentedCarOfTheSpecialModel(modelToSearch);
        return Ok(vehicles);
    }

    /// <summary>
    /// Возвращает список всех автомобилей, находящихся в аренде 
    /// </summary>
    /// <returns>Список автомобилей, находящихся в аренде</returns>
    [HttpGet("carsOnRentRightNow")]
    public ActionResult<List<RentalClientGetDTO>> GetCarsOnRentRightNow()
    {
        var vehicles = requestService.CarsOnRentRightNow();
        return Ok(vehicles);
    }

    /// <summary>
    /// Возвращает список из топ-5 автомобилей по кол-ву аренд
    /// </summary>
    /// <returns>Список из топ-5 автомобилей по кол-ву аренд</returns>
    [HttpGet("top5Cars")]
    public ActionResult<List<VehicleGetDTO>> GetTop5CarsOnRent()
    {
        var vehicles = requestService.Top5CarsOnRent();
        return Ok(vehicles);
    }

    /// <summary>
    /// Возвращает список количества аренд для каждой модели автомобиля
    /// </summary>
    /// <returns>Список  количества аренд для каждой модели автомобиля</returns>
    [HttpGet("numberOfCarRentals")]
    public ActionResult<List<RentalCounterDTO>> GetNumberOfRentForEachVehicle()
    {
        var vehicles = requestService.NumberOfRentForEachVehicle();
        var result = new List<RentalCounterDTO>();
        foreach (var vehicle in vehicles)
            result.Add(new RentalCounterDTO(vehicle.Item1, vehicle.Item2));
        return Ok(result);
    }

    /// <summary>
    /// Возвращает список точек проката по количеству аренд
    /// </summary>
    /// <returns>Список точек проката по количеству аренд</returns>
    [HttpGet("rentalPointsWithMostRents")]
    public ActionResult<List<RentalPointGetDTO>> GetRentalPointsWithMostRents()
    {
        var vehicles = requestService.RentalPointsWithMostRents();
        return Ok(vehicles);
    }
}

