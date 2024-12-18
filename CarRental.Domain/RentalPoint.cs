﻿namespace CarRental.Domain;

/// <summary>
/// Реализация пункта проката
/// </summary>
/// <param name="id">Идентификатор пункта</param>
/// <param name="name">Название пункта</param>
/// <param name="address">Адрес пункта</param>
public class RentalPoint(int id, string name, string address)
{
    /// <summary>
    /// Идентификатор пункта проката
    /// </summary>
    public int? Id { get; set; } = id;

    /// <summary>
    /// Название пункта проката
    /// </summary>
    public string? Name { get; set; } = name;

    /// <summary>
    /// Адрес пункта проката
    /// </summary>
    public string? Address { get; set; } = address;
}