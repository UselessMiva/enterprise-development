using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRental.Domain.Repository;

public class CarOnRentRepository() : ICarOnRentRepository 
{
    private static readonly List<CarOnRent> _carsOnRent = [];
    /// <inheritdoc />
    public List<CarOnRent> GetAll() => _carsOnRent;


    /// <inheritdoc />  
    public CarOnRent? Get(int id) => _carsOnRent.Find(d => d.Id == id);

    /// <inheritdoc />
    public void Post(CarOnRent newObj)
    {
        newObj.Id = _carsOnRent.Count;
        _carsOnRent.Add(newObj);
    }

    /// <inheritdoc />
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

    /// <inheritdoc />
    public bool Delete(int id)
    {
        var deletedCarOnRent = Get(id);
        if (deletedCarOnRent == null) return false;
        _carsOnRent.Remove(deletedCarOnRent);
        return true;
    }
}

