using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRental.Domain.Repository;

/// <summary>
/// Обобщенный интерфейс репозитория
/// </summary>
public interface IRepository<T>
{
    /// <summary>
    /// Получение всех сущностей
    /// </summary>
    public IEnumerable<T> GetAll();

    /// <summary>
    /// Получение сущности по id
    /// </summary>
    public T? GetById(int id);

    /// <summary>
    /// Создание сущности
    /// </summary>
    public T Create(T entity);

    /// <summary>
    /// Изменение сущности
    /// </summary>
    public T Update(T entity);

    /// <summary>
    /// Удаление сущности
    /// </summary>
    public void Delete(T entity);
}
