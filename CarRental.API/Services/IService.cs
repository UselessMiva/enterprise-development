using CarRental.API.DTO;

namespace CarRental.API.Services;

/// <summary>
/// Интерфейс для сервисов сущностей
/// </summary>
/// <typeparam name="GetDTO">Тип сущности Dto</typeparam>
/// <typeparam name="PostDTO">Тип сущности</typeparam>
public interface IService<GetDTO, PostDTO>
{
    /// <summary>
    /// Получение всех сущностей
    /// </summary>
    /// <returns>Список сущностей</returns>
    public IEnumerable<GetDTO> GetAll();

    /// <summary>
    /// Получение сущности по идентификатору 
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Сущность с выбранным идентификатором</returns>
    public GetDTO? Get(int id);

    /// <summary>
    /// Добавление сущности
    /// </summary>
    /// <param name="entity">Новая сущность</param>
    /// <returns>Добавленная сущность</returns>
    public GetDTO? Post(PostDTO entity);

    /// <summary>
    /// Обновляет сущность по идентификатору 
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <param name="entity">Новая сущность</param>
    /// <returns>Результат операции</returns>
    public bool Put(int id, PostDTO entity);

    /// <summary>
    /// Удаляет сущность по идентификатору 
    /// </summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <returns>Результат операции</returns>
    public bool Delete(int id);
}
