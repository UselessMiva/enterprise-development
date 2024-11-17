using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRental.Domain.Repository;

/// <summary>
/// Репозиторий для управления автомобилями в аренде
/// </summary>
public class CarOnRentRepository() : IRepository<CarOnRent>
{
    private static readonly List<CarOnRent> _carsOnRent = [];

    /// <summary>
    /// Возвращает список всех автомобилей в аренде
    /// </summary>
    /// <returns>Список автомобилей</returns>
    public List<CarOnRent> GetAll() => _carsOnRent;

    /// <summary>
    /// Находит автомобиль в аренде по заданному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор автомобиля в аренде</param>
    /// <returns>Если найден, то возвращает автомобиль; иначе null</returns>
    public CarOnRent? Get(int id) => _carsOnRent.Find(d => d.Id == id);

    /// <summary>
    /// Добавляет новый автомобиль в аренде в репозиторий
    /// </summary>
    /// <param name="newObj">Новый объект автомобиль для добавления</param>
    /// <returns>Добавленный объект</returns>
    public CarOnRent? Post(CarOnRent newObj)
    {
        _carsOnRent.Add(newObj);
        return newObj;
    }

    /// <summary>
    /// Обновляет информацию об автомобиле в аренде по заданному идентификатору
    /// </summary>
    /// <param name="newObj">Объект автомобиль с новыми данными</param>
    /// <param name="id">Идентификатор автомобиля для обновления</param>
    /// <returns>true, если обновление прошло успешно; иначе false</returns>
    public bool Put(CarOnRent newObj, int id)
    {
        var oldCarOnRent = Get(id);
        if (oldCarOnRent == null) return false;
        oldCarOnRent.Id = newObj.Id;
        oldCarOnRent.RentalPointGetFrom = newObj.RentalPointGetFrom;
        oldCarOnRent.Client= newObj.Client;
        oldCarOnRent.Vehicle = newObj.Vehicle;
        oldCarOnRent.RentalPointReturnTo = newObj.RentalPointReturnTo;
        oldCarOnRent.RentalTime = newObj.RentalTime;
        oldCarOnRent.ReturnTime = newObj.ReturnTime;
        oldCarOnRent.RentalDuration = newObj.RentalDuration;
        return true;
    }

    /// <summary>
    /// Удаляет автомобиль из аренды по заданному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор автомобиля для удаления</param>
    /// <returns>true, если удаление прошло успешно; иначе false</returns>
    public bool Delete(int id)
    {
        var deletedCarOnRent = Get(id);
        if (deletedCarOnRent == null) return false;
        _carsOnRent.Remove(deletedCarOnRent);
        return true;
    }
}

