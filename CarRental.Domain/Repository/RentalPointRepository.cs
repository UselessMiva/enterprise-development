using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRental.Domain.Repository;

/// <summary>
/// Репозиторий для управления пунктами аренды
/// </summary>
public class RentalPointRepository(TestDataProvider dataProvider) : IRepository<RentalPoint>
{
    private readonly List<RentalPoint> _rentalPoints = new List<RentalPoint>(dataProvider.rentalPoints);

    /// <summary>
    /// Получает список всех пунктов аренды
    /// </summary>
    /// <returns>Список овсех пунктов аренды</returns>
    public List<RentalPoint> GetAll() => _rentalPoints;

    /// <summary>
    /// Находит пункт аренды по заданному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор пункта аренды</param>
    /// <returns>Пункт аренды, если найден; иначе null</returns>
    public RentalPoint? Get(int id) => _rentalPoints.Find(d => d.Id == id);

    /// <summary>
    /// Добавляет новый пункт аренды 
    /// </summary>
    /// <param name="newObj">Новый пункт аренды для добавления</param>
    /// <returns>Добавленный пункт аренды</returns>
    public RentalPoint Post(RentalPoint newObj)
    {
        _rentalPoints.Add(newObj);
        return newObj;
    }

    /// <summary>
    /// Обновляет информацию о пункте аренды по заданному идентификатору
    /// </summary>
    /// <param name="newObj">Пункт аренды с новыми данными</param>
    /// <param name="id">Идентификатор пункта аренды для обновления</param>
    /// <returns>true, если обновление прошло успешно; иначе false</returns>
    public bool Put(RentalPoint newObj, int id)
    {
        var oldRentalPoint = Get(id);
        if (oldRentalPoint == null) return false;
        oldRentalPoint.Id = newObj.Id;
        oldRentalPoint.Address = newObj.Address;
        oldRentalPoint.Name = newObj.Name;
        return true;
    }

    /// <summary>
    /// Удаляет пункт аренды по заданному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор пункта аренды для удаления</param>
    /// <returns>true, если удаление прошло успешно; иначе false</returns>
    public bool Delete(int id)
    {
        var deletedRentalPoint = Get(id);
        if (deletedRentalPoint == null) return false;
        _rentalPoints.Remove(deletedRentalPoint);
        return true;
    }
}
