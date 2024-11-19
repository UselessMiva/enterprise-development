using CarRental.Domain;
namespace CarRental.API.DTO;

/// <summary>
/// Аренда автомобиля
/// </summary>
public class CarOnRentDTO
    {
        /// <summary>
        /// Идентификатор аренды
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Арендуемый автомобиль
        /// </summary>
        public Vehicle? Vehicle { get; set; }

        /// <summary>
        /// Клиент, который арендует автомобиль
        /// </summary>
        public RentalClient? Client { get; set; }

        /// <summary>
        /// Пункт аренды, откуда берется автомобиль
        /// </summary>
        public RentalPoint? RentalPointGetFrom { get; set; }

        /// <summary>
        /// Время, когда был взят автомобиль
        /// </summary>
        public DateTime? RentalTime { get; set; }

        /// <summary>
        /// Время, когда был возвращен автомобиль
        /// </summary>
        public DateTime? ReturnTime { get; set; }

        /// <summary>
        /// Время, на которое был взят автомобиль
        /// </summary>
        public TimeSpan? RentalDuration { get; set; }

        /// <summary>
        /// Пункт, в который был возвращен автомобиль
        /// </summary>
        public RentalPoint? RentalPointReturnTo { get; set; }
    }


