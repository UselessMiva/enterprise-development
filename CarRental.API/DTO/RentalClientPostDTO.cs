namespace CarRental.API.DTO;

public class RentalClientPostDTO
{
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
