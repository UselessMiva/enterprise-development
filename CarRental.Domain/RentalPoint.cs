using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Domain;

/// <summary>
/// Реализация пункта проката
/// </summary>
[Table("rental_point")]
public class RentalPoint
{
    /// <summary>
    /// Идентификатор пункта проката
    /// </summary>
    [Key]
    [Column("id")]
    public int? Id { get; set; }

    /// <summary>
    /// Название пункта проката
    /// </summary>
    [Column("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Адрес пункта проката
    /// </summary>
    [Column("address")]
    public string? Address { get; set; }

    // Параметрless конструктор
    public RentalPoint() { }

    // Конструктор с параметрами
    public RentalPoint(int id, string name, string address)
    {
        Id = id;
        Name = name;
        Address = address;
    }
}