using System.Numerics;

namespace CarRental.Domain.Repository;
public class VehicleRepository() : IRepository<Vehicle>
{
    private static readonly List<Vehicle> _vehicles = [];
    
    public List<Vehicle> GetAll() => _vehicles;
    
    public Vehicle? Get(int id) => _vehicles.Find(d => d.Id == id);
    
    public Vehicle? Post(Vehicle newObj)
    {
        _vehicles.Add(newObj);
        return newObj;
    }
  
    public bool Delete(int id)
    {
        var deletedVehicle = Get(id);
        if (deletedVehicle == null) return false;
        _vehicles.Remove(deletedVehicle);
        return true;
    }

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
}
