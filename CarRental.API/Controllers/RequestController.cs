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
public class RequestController(RequestService requestService) : ControllerBase
{
    /// <summary>
    /// Возвращает список всех автомобилей
    /// </summary>
    /// <returns>Список автомобилей</returns>
    [HttpGet("allVehciles")]
    public ActionResult<List<VehicleDTO>> GetAllVehciles()
    {
        var vehicles = requestService.ReturnAllCars();
        return Ok(vehicles);
    }

    /// <summary>
    /// Возвращает список клиентов, арендовавших автомобиль определённой модели
    /// </summary>
    /// <returns>Список клиентов, арендовавших автомобиль определённой модели</returns>
    [HttpGet("clientsWhoRented")]
    public ActionResult<List<VehicleDTO>> GetClientsWhoRentedCarOfTheSpecialModel(string modelToSearch)
    {
        var vehicles = requestService.ClientsWhoRentedCarOfTheSpecialModel(modelToSearch);
        return Ok(vehicles);
    }

    /// <summary>
    /// Возвращает список всех автомобилей, находящихся в аренде 
    /// </summary>
    /// <returns>Список автомобилей, находящихся в аренде</returns>
    [HttpGet("carsOnRentRightNow")]
    public ActionResult<List<RentalClientDTO>> GetCarsOnRentRightNow()
    {
        var vehicles = requestService.CarsOnRentRightNow();
        return Ok(vehicles);
    }

    /// <summary>
    /// Возвращает список из топ-5 автомобилей по кол-ву аренд
    /// </summary>
    /// <returns>Список из топ-5 автомобилей по кол-ву аренд</returns>
    [HttpGet("top5Cars")]
    public ActionResult<List<VehicleDTO>> GetTop5CarsOnRent()
    {
        var vehicles = requestService.Top5CarsOnRent();
        return Ok(vehicles);
    }

    /// <summary>
    /// Возвращает список количества аренд для каждой модели автомобиля
    /// </summary>
    /// <returns>Список  количества аренд для каждой модели автомобиля</returns>
    [HttpGet("numberOfCarRentals")]
    public ActionResult<object> GetNumberOfRentForEachVehicle()
    {
        var vehicles = requestService.NumberOfRentForEachVehicle();
        return Ok(vehicles);
    }

    /// <summary>
    /// Возвращает список точек проката по количеству аренд
    /// </summary>
    /// <returns>Список точек проката по количеству аренд</returns>
    [HttpGet("rentalPointsWithMostRents")]
    public ActionResult<List<RentalPointDTO>> GetRentalPointsWithMostRents()
    {
        var vehicles = requestService.RentalPointsWithMostRents();
        return Ok(vehicles);
    }
}

