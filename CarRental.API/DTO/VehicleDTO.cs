namespace CarRental.API.DTO;

/// <summary>
/// Реализация автомобиля
/// </summary>
public class VehicleDTO(int id, string carNumber, string model, string color)
{
    /// <summary>
    /// Идентификатор автомобиля
    /// </summary>
    public int? Id { get; set; } = id;

    /// <summary>
    /// Номер автомобиля
    /// </summary>
    public string? CarNumber { get; set; } = carNumber;

    /// <summary>
    /// Модель автомобиля
    /// </summary>
    public string? Model { get; set; } = model;

    /// <summary>
    /// Цвет автомобиля
    /// </summary>
    public string? Color { get; set; } = color;
}
