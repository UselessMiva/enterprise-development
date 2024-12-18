namespace CarRental.API.DTO;

public class VehiclePostDTO
{
    /// <summary>
    /// Номер автомобиля
    /// </summary>
    public string? CarNumber { get; set; }

    /// <summary>
    /// Модель автомобиля
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// Цвет автомобиля
    /// </summary>
    public string? Color { get; set; }
}
