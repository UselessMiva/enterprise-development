namespace CarRental.API.DTO;

/// <summary>
/// Реализация автомобиля
/// </summary>
public class VehicleDTO
{
    /// <summary>
    /// Идентификатор автомобиля
    /// </summary>
    public int? Id { get; set; }

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
