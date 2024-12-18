using AutoMapper;
using CarRental.API.DTO;
using CarRental.Domain.Repository;
using CarRental.Domain;
namespace CarRental.API.Services;

/// <summary>
/// Сервис для управления данными об автомобилях, выданных в аренду
/// Реализует интерфейс IService для выполнения операций CRUD с автомобилями, выданными в аренду
/// </summary>
public class CarOnRentService(IRepository<CarOnRent> carOnRentRepository, IMapper mapper) : IService<CarOnRentGetDTO, CarOnRentPostDTO>
{
    private int _id = 1;

    /// <summary>
    /// Получает список всех автомобилей, выданных в аренду
    /// </summary>
    /// <returns>Список всех автомобилей, выданных в аренду</returns>
    public IEnumerable<CarOnRentGetDTO> GetAll()
    {
        return carOnRentRepository.GetAll().Select(mapper.Map<CarOnRentGetDTO>);
    }

    /// <summary>
    /// Получает автомобиль, выданный в аренду, по указанному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор автомобиля, выданного в аренду</param>
    /// <returns>Автомобиль, выданный в аренду, с указанным идентификатором или null, если не найден.</returns>
    public CarOnRentGetDTO Get(int id)
    {
        var carOnRent = carOnRentRepository.Get(id);
        return mapper.Map<CarOnRentGetDTO>(carOnRent);
    }

    /// <summary>
    /// Добавление нового автомобиля, выданного в аренду
    /// </summary>
    /// <param name="entity">DTO объекта автомобиль, выданный в аренду, для добавления</param>
    /// <returns>Добавленный автомобиль или null, если не добавлен</returns>
    public CarOnRentGetDTO? Post(CarOnRentPostDTO entity)
    {
        var carOnRent = mapper.Map<CarOnRent>(entity);
        carOnRent.Id = _id++;
        return mapper.Map<CarOnRentGetDTO>(carOnRentRepository.Post(carOnRent));
    }

    /// <summary>
    /// Обновлен6ие данных об автомобиле,выданном в аренду, по его id
    /// </summary>
    /// <param name="id">Идентификатор автомобиля,выданного в аренду, для обновления</param>
    /// <param name="entity">DTO объекта автомобиль, выданный в аренду, с новыми данными</param>
    /// <returns>True, если обновлен, иначе - False</returns>
    public bool Put(int id, CarOnRentPostDTO entity)
    {
        var carOnRent = mapper.Map<CarOnRent>(entity);
        return carOnRentRepository.Put(carOnRent, id);
    }

    /// <summary>
    /// Удаляет автомобиль, выданный в аренду, по указанному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор автомобиля, выданного в аренду, для удаления</param>
    /// <returns>True, если успешно удален, иначе - False</returns>
    public bool Delete(int id)
    {
        return carOnRentRepository.Delete(id);
    }
}
