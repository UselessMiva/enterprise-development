using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRental.Domain.Repository;

public class RentalPointRepository() : IRentalPointRepository
{

    private static readonly List<RentalPoint> _rentalPoints = [];
    /// <inheritdoc />
    public List<RentalPoint> GetAll() => _rentalPoints;


    /// <inheritdoc />  
    public RentalPoint? Get(int id) => _rentalPoints.Find(d => d.Id == id);

    /// <inheritdoc />
    public void Post(RentalPoint newObj)
    {
        newObj.Id = _rentalPoints.Count;
        _rentalPoints.Add(newObj);
    }

    /// <inheritdoc />
    public bool Put(RentalPoint newObj, int id)
    {
        var oldRentalPoint = Get(id);
        if (oldRentalPoint == null) return false;
        oldRentalPoint.Id = newObj.Id;
        oldRentalPoint.Address = newObj.Address;
        oldRentalPoint.Name = newObj.Name;
        return true;
    }

    /// <inheritdoc />
    public bool Delete(int id)
    {
        var deletedRentalPoint = Get(id);
        if (deletedRentalPoint == null) return false;
        _rentalPoints.Remove(deletedRentalPoint);
        return true;
    }
}
