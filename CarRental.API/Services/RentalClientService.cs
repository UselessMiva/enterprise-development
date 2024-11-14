using AutoMapper;
using CarRental.API.DTO;
using CarRental.Domain.Repository;
using CarRental.Domain;
namespace CarRental.API.Services;

/// <summary>
/// Сервис для управления данными о клиентах
/// Реализует интерфейс IService для выполнения операций CRUD с клиентами
/// </summary>
public class RentalClientService(IRepository<RentalClient> rentalClientRepository, IMapper mapper) : IService<RentalClientDTO, RentalClient>
{
    private int _id = 1;


    /// <summary>
    /// Получает список всех клиентов
    /// </summary>
    /// <returns>Список всех клиентов</returns>
    public IEnumerable<RentalClient> GetAll()
    {
        return rentalClientRepository.GetAll();
    }

    /// <summary>
    /// Получает клиента по указанному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор клиента</param>
    /// <returns>Клиента с указанным идентификатором или null, если не найден.</returns>
    public RentalClient Get(int id)
    {
        var rentalClient = rentalClientRepository.Get(id);
        return rentalClient;
    }

    /// <summary>
    /// Добавление нового клиента
    /// </summary>
    /// <param name="entity">DTO объекта клиент для добавления</param>
    /// <returns>Добавленный клиент или null, если не добавлен</returns>
    public RentalClient? Post(RentalClientDTO entity)
    {
        var rentalClient = mapper.Map<RentalClient>(entity);
        rentalClient.Id = _id++;
        return rentalClientRepository.Post(rentalClient);
    }

    /// <summary>
    /// Обновлен6ие данных о клиенте по его id
    /// </summary>
    /// <param name="id">Идентификатор клиента для обновления</param>
    /// <param name="entity">DTO объекта клиент с новыми данными</param>
    /// <returns>True, если обновлен, иначе - False</returns>
    public bool Put(int id, RentalClientDTO entity)
    {
        var rentalClient = mapper.Map<RentalClient>(entity);
        return rentalClientRepository.Put(rentalClient, id);
    }

    /// <summary>
    /// Удаляет клиента по указанному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор клиента для удаления</param>
    /// <returns>True, если успешно удален, иначе - False</returns>
    public bool Delete(int id)
    {
        return rentalClientRepository.Delete(id);
    }
}
