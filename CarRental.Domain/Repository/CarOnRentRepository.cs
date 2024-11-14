using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRental.Domain.Repository;

public class CarOnRentRepository() : IRepository<CarOnRent>
{
    private static readonly List<CarOnRent> _carsOnRent = [];
    /// 
    public List<CarOnRent> GetAll() => _carsOnRent;


    /// 
    public CarOnRent? Get(int id) => _carsOnRent.Find(d => d.Id == id);

    /// 
    public CarOnRent? Post(CarOnRent newObj)
    {
        _carsOnRent.Add(newObj);
        return newObj;
    }

    /// 
    public bool Put(CarOnRent newObj, int id)
    {
        var oldCarOnRent = Get(id);
        if (oldCarOnRent == null) return false;
        oldCarOnRent.Id = newObj.Id;
        oldCarOnRent.RentalPointGetFrom = newObj.RentalPointGetFrom;
        oldCarOnRent.Client= newObj.Client;
        oldCarOnRent.Vehicle = newObj.Vehicle;
        oldCarOnRent.RentalPointReturnTo = newObj.RentalPointReturnTo;
        oldCarOnRent.RentalTime = newObj.RentalTime;
        oldCarOnRent.ReturnTime = newObj.ReturnTime;
        oldCarOnRent.RentalDuration = newObj.RentalDuration;
        return true;
    }

    /// 
    public bool Delete(int id)
    {
        var deletedCarOnRent = Get(id);
        if (deletedCarOnRent == null) return false;
        _carsOnRent.Remove(deletedCarOnRent);
        return true;
    }
}

