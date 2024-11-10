using System.Numerics;

namespace CarRental.Domain.Repository;

/// <summary>
/// Класс реализует интерфейс <see cref="IVehicleRepository" />
/// </summary>
public class VehicleRepository() : IVehicleRepository
{
    private static readonly List<Vehicle> _vehicles = [];
    /// <inheritdoc />
    public List<Vehicle> GetAll() => _vehicles;


    /// <inheritdoc />  
    public Vehicle? Get(int id) => _vehicles.Find(d => d.Id == id);

    /// <inheritdoc />
    public void Post(Vehicle newObj)
    {
        newObj.Id = _vehicles.Count;
        _vehicles.Add(newObj);
    }

    /// <inheritdoc />
    public bool Put(Vehicle newObj, int id)
    {
        var oldVehicle = Get(id);
        if (oldVehicle == null) return false;
        oldVehicle.Id = newObj.Id;
        oldVehicle.CarNumber = newObj.CarNumber;
        oldVehicle.Model = newObj.Model;
        oldVehicle.Color = newObj.Color;
        return true;
    }

    /// <inheritdoc />
    public bool Delete(int id)
    {
        var deletedVehicle = Get(id);
        if (deletedVehicle == null) return false;
        _vehicles.Remove(deletedVehicle);
        return true;
    }

    
}
