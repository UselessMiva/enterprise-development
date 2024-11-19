using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRental.Domain.Repository;

/// <summary>
/// Репозиторий для управления клиентами аренды
/// </summary>
public class RentalClientRepository(TestDataProvider dataProvider) : IRepository<RentalClient>
{
    private readonly List<RentalClient> _rentalclients = new List<RentalClient>(dataProvider.clients);

    /// <summary>
    /// Получает список всех клиентов аренды
    /// </summary>
    /// <returns>Список клиентов</returns>
    public List<RentalClient> GetAll() =>  _rentalclients;

    /// <summary>
    /// Находит клиента аренды по заданному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор клиента</param>
    /// <returns>Клиент, если найден; иначе null</returns>
    public RentalClient? Get(int id) =>  _rentalclients.Find(d => d.Id == id);

    /// <summary>
    /// Добавляет нового клиента аренды в репозиторий
    /// </summary>
    /// <param name="newObj">Новый клиент для добавлений</param>
    /// <returns>Добавленный клиент</returns>
    public RentalClient Post(RentalClient newObj)
    {
         _rentalclients.Add(newObj);
        return newObj;
    }

    /// <summary>
    /// Обновляет информацию о клиенте аренды по заданному идентификатору
    /// </summary>
    /// <param name="newObj">Клиент с новыми данными</param>
    /// <param name="id">Идентификатор клиента для обновления</param>
    /// <returns>true, если обновление прошло успешно; иначе false</returns>
    public bool Put(RentalClient newObj, int id)
    {
        var oldRentalClient = Get(id);
        if (oldRentalClient == null) return false;
        oldRentalClient.Id = newObj.Id;
        oldRentalClient.Passport = newObj.Passport;
        oldRentalClient.FullName = newObj.FullName;
        return true;
    }

    /// <summary>
    /// Удаляет клиента аренды по заданному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор клиента для удаления</param>
    /// <returns>true, если удаление прошло успешно; иначе false</returns>
    public bool Delete(int id)
    {
        var deletedRentalClient = Get(id);
        if (deletedRentalClient == null) return false;
         _rentalclients.Remove(deletedRentalClient);
        return true;
    }
}
