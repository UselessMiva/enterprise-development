﻿namespace CarRental.Domain;

/// <summary>
/// Реализация клиента проката
/// </summary>
/// <param name="id">Идентификатор клиента</param>
/// <param name="passport">Паспорт клиента</param>
/// <param name="fullName">ФИО клиента</param>
/// <param name="birthDate">Дата рождения клиента</param>
public class RentalClient(int id, string passport, string fullName, DateTime birthDate)
{
    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    public int? Id { get; set; } = id;

    /// <summary>
    /// Паспорт клиента
    /// </summary>
    public string? Passport { get; set; } = passport;

    /// <summary>
    /// ФИО клиента
    /// </summary>
    public string? FullName { get; set; } = fullName;

    /// <summary>
    /// Дата рождения клиента
    /// </summary>
    public DateTime? BirthDate { get; set; } = birthDate;
}
