namespace CarRental.API.DTO;

/// <summary>
/// Реализация пункта проката
/// </summary>
public class RentalPointDTO(int id, string name, string address)
{
    /// <summary>
    /// Идентификатор пункта проката
    /// </summary>
    public int? Id { get; set; } = id;

    /// <summary>
    /// Название пункта проката
    /// </summary>
    public string? Name { get; set; } = name;

    /// <summary>
    /// Адрес пункта проката
    /// </summary>
    public string? Address { get; set; } = address;
}
