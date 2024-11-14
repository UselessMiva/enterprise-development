﻿using AutoMapper;
using CarRental.API.DTO;
using CarRental.Domain;
using CarRental.Domain.Repository;
namespace CarRental.API.Services;

/// <summary>
/// Сервис для управления данными о пунктах проката
/// Реализует интерфейс IService для выполнения операций CRUD с пунктами проката
/// </summary>
public class RentalPointService(IRepository<RentalPoint> rentalPointRepository, IMapper mapper) : IService<RentalPointDTO, RentalPoint>
{
    private int _id = 1;


    /// <summary>
    /// Получает список всех пунктов проката
    /// </summary>
    /// <returns>Список всех пунктов проката</returns>
    public IEnumerable<RentalPoint> GetAll()
    {
        return rentalPointRepository.GetAll();
    }

    /// <summary>
    /// Получает пункт проката по указанному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор пункта проката</param>
    /// <returns>Пункта проката с указанным идентификатором или null, если не найден.</returns>
    public RentalPoint Get(int id)
    {
        var rentalPoint = rentalPointRepository.Get(id);
        return rentalPoint;
    }

    /// <summary>
    /// Добавление нового пункта проката
    /// </summary>
    /// <param name="entity">DTO объекта пункт проката для добавления</param>
    /// <returns>Добавленный пункт проката или null, если не добавлен</returns>
    public RentalPoint? Post(RentalPointDTO entity)
    {
        var rentalPoint = mapper.Map<RentalPoint>(entity);
        rentalPoint.Id = _id++;
        return rentalPointRepository.Post(rentalPoint);
    }

    /// <summary>
    /// Обновлен6ие данных о пункте проката по его id
    /// </summary>
    /// <param name="id">Идентификатор пункта проката для обновления</param>
    /// <param name="entity">DTO объекта пункт проката с новыми данными</param>
    /// <returns>True, если обновлен, иначе - False</returns>
    public bool Put(int id, RentalPointDTO entity)
    {
        var rentalPoint = mapper.Map<RentalPoint>(entity);
        return rentalPointRepository.Put(rentalPoint, id);
    }

    /// <summary>
    /// Удаляет пункта проката по указанному идентификатору
    /// </summary>
    /// <param name="id">Идентификатор пункта проката для удаления</param>
    /// <returns>True, если успешно удален, иначе - False</returns>
    public bool Delete(int id)
    {
        return rentalPointRepository.Delete(id);
    }
}