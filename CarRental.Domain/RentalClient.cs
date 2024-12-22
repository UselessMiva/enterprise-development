using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarRental.Domain;

/// <summary>
/// Реализация клиента проката
/// </summary>
[Table("rental_client")]
public class RentalClient
{
    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    [Key]
    [Column("id")]
    public int? Id { get; set; }

    /// <summary>
    /// Паспорт клиента
    /// </summary>
    [Column("passport")]
    public string? Passport { get; set; }

    /// <summary>
    /// ФИО клиента
    /// </summary>
    [Column("full_name")]
    public string? FullName { get; set; }

    /// <summary>
    /// Дата рождения клиента
    /// </summary>
    [Column("birth_date")]
    public DateTime? BirthDate { get; set; }

    // Параметрless конструктор
    public RentalClient() { }

    // Конструктор с параметрами
    public RentalClient(int id, string passport, string fullName, DateTime birthDate)
    {
        Id = id;
        Passport = passport;
        FullName = fullName;
        BirthDate = birthDate;
    }
}