﻿namespace CarRental.Domain;

/// <summary>
/// Реализация автомобиля
/// </summary>
/// <param name="id">Идентификатор автомобиля</param>
/// <param name="carNumber">Номер автомобиля</param>
/// <param name="model">Модель автомобиля</param>
/// <param name="color">Цвет автомобиля</param>
public class Vehicle(int id, string carNumber, string model, string color)
{
    /// <summary>
    /// Идентификатор автомобиля
    /// </summary>
    public int? Id { get; set; } = id;

    /// <summary>
    /// Номер автомобиля
    /// </summary>
    public string? CarNumber { get; set; } = carNumber;

    /// <summary>
    /// Модель автомобиля
    /// </summary>
    public string? Model { get; set; } = model;

    /// <summary>
    /// Цвет автомобиля
    /// </summary>
    public string? Color { get; set; } = color;
}
