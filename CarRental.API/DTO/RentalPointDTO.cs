namespace CarRental.API.DTO;

/// <summary>
/// Реализация пункта проката
/// </summary>
public class RentalPointDTO
{
    /// <summary>
    /// Идентификатор пункта проката
    /// </summary>
    public int? Id { get; set; }

    /// <summary>
    /// Название пункта проката
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Адрес пункта проката
    /// </summary>
    public string? Address { get; set; }
}
