namespace CarRental.API.DTO;

/// <summary>
/// Клиент проката автомобилей
/// </summary>
public class RentalClientDTO(int id, string passport, string fullName, DateTime birthDate)
{
    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    public int? Id { get; set; } = id;

    /// <summary>
    /// Паспорт клиента
    /// </summary>
    public string? Passport { get; set; } = passport;

    /// <summary>
    /// ФИО клиента
    /// </summary>
    public string? FullName { get; set; } = fullName;

    /// <summary>
    /// Дата рождения клиента
    /// </summary>
    public DateTime? BirthDate { get; set; } = birthDate;
}
