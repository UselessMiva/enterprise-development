using CarRental.Domain;
namespace CarRental.API.DTO;

/// <summary>
/// Аренда автомобиля
/// </summary>
public class CarOnRentDTO(int id, Vehicle vehicle, RentalClient client, RentalPoint rentalPointGetFrom,
DateTime rentalTimeGet, TimeSpan rentalDuration,
DateTime? rentalTimeReturn = null, RentalPoint? rentalPointReturnTo = null)
    {
        /// <summary>
        /// Идентификатор аренды
        /// </summary>
        public int? Id { get; set; } = id;

        /// <summary>
        /// Арендуемый автомобиль
        /// </summary>
        public Vehicle? Vehicle { get; set; } = vehicle;

        /// <summary>
        /// Клиент, который арендует автомобиль
        /// </summary>
        public RentalClient? Client { get; set; } = client;

        /// <summary>
        /// Пункт аренды, откуда берется автомобиль
        /// </summary>
        public RentalPoint? RentalPointGetFrom { get; set; } = rentalPointGetFrom;

        /// <summary>
        /// Время, когда был взят автомобиль
        /// </summary>
        public DateTime? RentalTime { get; set; } = rentalTimeGet;

        /// <summary>
        /// Время, когда был возвращен автомобиль
        /// </summary>
        public DateTime? ReturnTime { get; set; } = rentalTimeReturn;

        /// <summary>
        /// Время, на которое был взят автомобиль
        /// </summary>
        public TimeSpan? RentalDuration { get; set; } = rentalDuration;

        /// <summary>
        /// Пункт, в который был возвращен автомобиль
        /// </summary>
        public RentalPoint? RentalPointReturnTo { get; set; } = rentalPointReturnTo;
    }


