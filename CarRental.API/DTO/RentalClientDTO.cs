namespace CarRental.API.DTO;

/// <summary>
/// Клиент проката автомобилей
/// </summary>
public class RentalClientDTO
{
    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Паспорт клиента
    /// </summary>
    public string? Passport { get; set; }

    /// <summary>
    /// ФИО клиента
    /// </summary>
    public string? FullName { get; set; }

    /// <summary>
    /// Дата рождения клиента
    /// </summary>
    public DateTime? BirthDate { get; set; }
}
