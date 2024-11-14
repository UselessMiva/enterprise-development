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
    /// Вернуть все элементы
    /// </summary>
    /// <returns></returns>
    public List<T> GetAll();

    /// <summary>
    /// Вернуть элемент по идентификатору
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public T? Get(int id);

    /// <summary>
    /// Удалить элемент по идентификатору
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public bool Delete(int id);

    /// <summary>
    /// Добавить элемент
    /// </summary>
    /// <param name="newObj"></param>
    public T? Post(T newObj);

    /// <summary>
    /// Изменить элемент по идентификатору
    /// </summary>
    /// <param name="newObj"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public bool Put(T newObj, int id);
}