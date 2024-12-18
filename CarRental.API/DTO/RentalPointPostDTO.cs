namespace CarRental.API.DTO;

public class RentalPointPostDTO
{
    /// <summary>
    /// Название пункта проката
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Адрес пункта проката
    /// </summary>
    public string? Address { get; set; }
}
