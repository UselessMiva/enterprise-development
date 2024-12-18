using AutoMapper;
using CarRental.Domain;
using CarRental.API.DTO;
using CarRental.Domain.Repository;
namespace CarRental.API.Services;

/// <summary>
/// Сервис для управления данными об автомобилях
/// Реализует интерфейс IService для выполнения операций CRUD с автомобилями
/// </summary>
public class VehicleService( IRepository<Vehicle> vehicleRepository, IMapper mapper) : IService<VehicleGetDTO, VehiclePostDTO>
{
    private int _id = 1;

    /// <summary>
    /// Получает список всех автомобилей
    /// </summary>
    /// <returns>Список всех автомобилей</returns>
    public IEnumerable<VehicleGetDTO> GetAll()
    {
        return vehicleRepository.GetAll().Select(mapper.Map<VehicleGetDTO>);
    }

    /// <summary>
    /// Получает автомобиль по указанному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор автомобиля</param>
    /// <returns>Автомобиль с указанным идентификатором или null, если не найден.</returns>
    public VehicleGetDTO? Get(int id)
    {
        var vehicle = vehicleRepository.Get(id);
        return mapper.Map<VehicleGetDTO>(vehicle);
    }

    /// <summary>
    /// Добавление нового автомобиля
    /// </summary>
    /// <param name="entity">DTO объекта автомобиль для добавления</param>
    /// <returns>Добавленный автомобиль или null, если не добавлен</returns>
    public VehicleGetDTO? Post(VehiclePostDTO entity)
    {
        var vehicle = mapper.Map<Vehicle>(entity);
        vehicle.Id = _id++;
        return mapper.Map<VehicleGetDTO>(vehicleRepository.Post(vehicle));
    }

    /// <summary>
    /// Обновлен6ие данных об автомобиле по его id
    /// </summary>
    /// <param name="id">Идентификатор автомобиля для обновления</param>
    /// <param name="entity">DTO объекта автомобиль с новыми данными</param>
    /// <returns>True, если обновлен, иначе - False</returns>
    public bool Put(int id, VehiclePostDTO entity)
    {
        var vehicle = mapper.Map<Vehicle>(entity);
        return vehicleRepository.Put(vehicle, id);
    }
    
    /// <summary>
    /// Удаляет автомобиль по указанному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор автомобиля для удаления</param>
    /// <returns>True, если успешно удален, иначе - False</returns>
    public bool Delete(int id)
    {
        return vehicleRepository.Delete(id);
    }
}
