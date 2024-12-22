using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Domain;

/// <summary>
/// Реализация аренды автомобиля
/// </summary>
[Table("car_on_rent")]
public class CarOnRent
{
    /// <summary>
    /// Идентификатор аренды
    /// </summary>
    [Key]
    [Column("id")]
    public int? Id { get; set; }

    /// <summary>
    /// Арендуемый автомобиль
    /// </summary>
    [ForeignKey("vehicle")]
    public Vehicle? Vehicle { get; set; }

    /// <summary>
    /// Клиент, который арендует автомобиль
    /// </summary>
    [ForeignKey("rental_client")]
    public RentalClient? Client { get; set; }

    /// <summary>
    /// Пункт аренды, откуда берется автомобиль
    /// </summary>
    [ForeignKey("rental_point_get_from")]
    public RentalPoint? RentalPointGetFrom { get; set; }

    /// <summary>
    /// Время, когда был взят автомобиль
    /// </summary>
    [Column("rental_time")]
    public DateTime? RentalTime { get; set; }

    /// <summary>
    /// Время, когда был возвращен автомобиль
    /// </summary>
    [Column("return_time")]
    public DateTime? ReturnTime { get; set; }

    /// <summary>
    /// Время, на которое был взят автомобиль
    /// </summary>
    [Column("rental_duration")]
    public TimeSpan? RentalDuration { get; set; }

    /// <summary>
    /// Пункт, в который был возвращен автомобиль
    /// </summary>
    [ForeignKey("rental_point_return_to")]
    public RentalPoint? RentalPointReturnTo { get; set; }

    // Параметрless конструктор
    public CarOnRent() { }

    // Конструктор с параметрами
    public CarOnRent(int id, Vehicle vehicle, RentalClient client, RentalPoint rentalPointGetFrom,
                     DateTime rentalTimeGet, TimeSpan rentalDuration,
                     DateTime? rentalTimeReturn = null, RentalPoint? rentalPointReturnTo = null)
    {
        Id = id;
        Vehicle = vehicle;
        Client = client;
        RentalPointGetFrom = rentalPointGetFrom;
        RentalTime = rentalTimeGet;
        RentalDuration = rentalDuration;
        ReturnTime = rentalTimeReturn;
        RentalPointReturnTo = rentalPointReturnTo;
    }
}