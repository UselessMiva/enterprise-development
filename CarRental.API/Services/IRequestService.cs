using CarRental.Domain;
namespace CarRental.API.Services;

/// <summary>
/// Интерфейс для сервиса запросов
/// </summary>
public interface IRequestService
{
    /// <summary>
    /// Информация обо всех автомобилях
    /// </summary>
    public List<Vehicle> ReturnAllCars();

    /// <summary>
    /// Информация обо всех клиентах, арендовавших автомобиль определённой модели
    /// </summary>
    public List<RentalClient?> ClientsWhoRentedCarOfTheSpecialModel(string modelToSearch);

    /// <summary>
    /// Информация об автомобилях, находящихся в данный момент в аренде
    /// </summary>
    public List<Vehicle?> CarsOnRentRightNow();

    /// <summary>
    /// Информация о топ-5 автомобилей по количеству аренд
    /// </summary>
    public List<Vehicle?> Top5CarsOnRent();

    /// <summary>
    /// Информация о количестве аренд для каждого автомобиля
    /// </summary>
     public object NumberOfRentForEachVehicle();

    /// <summary>
    /// Информация о пунктах проката по количеству аренд
    /// </summary>
    public List<RentalPoint?> RentalPointsWithMostRents();
}
