using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Domain;

/// <summary>
/// Реализация автомобиля
/// </summary>
[Table("vehicle")]
public class Vehicle
{
    /// <summary>
    /// Идентификатор автомобиля
    /// </summary>
    [Key]
    [Column("id")]
    public int? Id { get; set; }

    /// <summary>
    /// Номер автомобиля
    /// </summary>
    [Column("car_number")]
    public string? CarNumber { get; set; }

    /// <summary>
    /// Модель автомобиля
    /// </summary>
    [Column("model")]
    public string? Model { get; set; }

    /// <summary>
    /// Цвет автомобиля
    /// </summary>
    [Column("color")]
    public string? Color { get; set; }

    // Параметрless конструктор
    public Vehicle() { }

    // Конструктор с параметрами
    public Vehicle(int id, string carNumber, string model, string color)
    {
        Id = id;
        CarNumber = carNumber;
        Model = model;
        Color = color;
    }
}