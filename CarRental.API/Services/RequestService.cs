using AutoMapper;
using CarRental.API.DTO;
using CarRental.Domain.Repository;
using CarRental.Domain;
using Microsoft.AspNetCore.Mvc;
namespace CarRental.API.Services;


/// <summary>
/// Сервис для работы с запросами
/// </summary>
public class RequestService(IRepository<Vehicle> vehicleRepository, IRepository<CarOnRent> carOnRentRepository) : IRequestService
{
    /// <summary>
    /// Информация обо всех автомобилях
    /// </summary>
    public List<Vehicle> ReturnAllCars()
    {
        var allVehicles = vehicleRepository.GetAll().ToList();
        return allVehicles;
    }

    /// <summary>
    /// Информация обо всех клиентах, арендовавших автомобиль определённой модели
    /// </summary>
    public List<RentalClient?> ClientsWhoRentedCarOfTheSpecialModel(string modelToSearch)
    {
        var clientsWhoOrderedCurrentModel = carOnRentRepository.GetAll()
            .Where(r => r.Vehicle!.Model == modelToSearch)
            .Select(r => r.Client)
            .Distinct()
            .OrderBy(c => c!.FullName)
            .ToList();
        return clientsWhoOrderedCurrentModel;
    }

    /// <summary>
    /// Информация об автомобилях, находящихся в данный момент в аренде
    /// </summary>
    public List<Vehicle?> CarsOnRentRightNow()
    {
        var carsOnRentRightNow = carOnRentRepository.GetAll()
            .Where(r => r.ReturnTime == null)
            .Select(r => r.Vehicle)
            .Distinct()
            .ToList();
        return carsOnRentRightNow;
    }

    /// <summary>
    /// Информация о топ-5 автомобилей по количеству аренд
    /// </summary>
    public List<Vehicle?> Top5CarsOnRent()
    {
        var top5RentedCars = carOnRentRepository.GetAll()
            .GroupBy(r => r.Vehicle)
            .OrderByDescending(g => g.Count())
            .Take(5)
            .Select(g => g.Key)
            .ToList();
        return top5RentedCars;
    }

    /// <summary>
    /// Информация о количестве аренд для каждого автомобиля
    /// </summary>
    public List<RentalCounterDto> NumberOfRentForEachVehicle()
    {
        var vehicleRentalCounts = carOnRentRepository.GetAll()
            .GroupBy(r => r.Vehicle)
            .Select(g => new RentalCounterDto(g.Key?.Model, g.Count()))
            .ToList();
        return vehicleRentalCounts;
    }

    /// <summary>
    /// Информация о пунктах проката по количеству аренд
    /// </summary>
    public List<RentalPoint?> RentalPointsWithMostRents()
    {
        var mostFrequentRentalPoints = carOnRentRepository.GetAll()
            .GroupBy(r => r.RentalPointGetFrom)
            .OrderByDescending(g => g.Count())
            .ThenBy(g => g.Key!.Name)
            .Select(g => g.Key)
            .Take(1)
            .ToList();
        return mostFrequentRentalPoints;
    }
}
