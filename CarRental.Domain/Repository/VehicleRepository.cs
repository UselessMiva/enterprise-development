using System.Numerics;
using CarRental.Domain;
namespace CarRental.Domain.Repository;

/// <summary>
/// Репозиторий для управления транспортными средствами
/// </summary>
public class VehicleRepository(TestDataProvider dataProvider): IRepository<Vehicle>
{
    private readonly List<Vehicle> _vehicles = new List<Vehicle>(dataProvider.vehicles);

    /// <summary>
    /// Получает список всех транспортных средств
    /// </summary>
    /// <returns>Список всех транспортных средств</returns>
    public List<Vehicle> GetAll() => _vehicles;

    /// <summary>
    /// Находит транспортное средство по заданному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор транспортного средства</param>
    /// <returnsАвтомобиль, если найден; иначе null</returns>
    public Vehicle? Get(int id) => _vehicles.Find(d => d.Id == id);

    /// <summary>
    /// Добавляет новое транспортное средство в репозиторий
    /// </summary>
    /// <param name="newObj">Новое транспортное средство для добавления</param>
    /// <returns>Добавленный автомобиль</returns>
    public Vehicle? Post(Vehicle newObj)
    {
        _vehicles.Add(newObj);
        return newObj;
    }

    /// <summary>
    /// Удаляет транспортное средство по заданному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор транспортного средства для удалени.</param>
    /// <returns>true, если удаление прошло успешно; иначе false</returns>
    public bool Delete(int id)
    {
        var deletedVehicle = Get(id);
        if (deletedVehicle == null) return false;
        _vehicles.Remove(deletedVehicle);
        return true;
    }

    /// <summary>
    /// Обновляет информацию о транспортном средстве по заданному идентификатору
    /// </summary>
    /// <param name="newObj">Автомобиль с новыми данными</param>
    /// <param name="id">Идентификатор транспортного средства для обновления</param>
    /// <returns>true, если обновление прошло успешно; иначе false</returns>
    public bool Put(Vehicle newObj, int id)
    {
        var oldVehicle = Get(id);
        if (oldVehicle == null) return false;
        oldVehicle.Id = newObj.Id;
        oldVehicle.CarNumber = newObj.CarNumber;
        oldVehicle.Model = newObj.Model;
        oldVehicle.Color = newObj.Color;
        return true;
    }
}
