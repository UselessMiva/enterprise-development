using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRental.Domain.Repository;

public class RentalPointRepository() : IRepository<RentalPoint>
{
    private static readonly List<RentalPoint> _rentalPoints = [];
    
    public List<RentalPoint> GetAll() => _rentalPoints;
  
    public RentalPoint? Get(int id) => _rentalPoints.Find(d => d.Id == id);
    
    public RentalPoint Post(RentalPoint newObj)
    {
        _rentalPoints.Add(newObj);
        return newObj;
    }

    public bool Put(RentalPoint newObj, int id)
    {
        var oldRentalPoint = Get(id);
        if (oldRentalPoint == null) return false;
        oldRentalPoint.Id = newObj.Id;
        oldRentalPoint.Address = newObj.Address;
        oldRentalPoint.Name = newObj.Name;
        return true;
    }

    public bool Delete(int id)
    {
        var deletedRentalPoint = Get(id);
        if (deletedRentalPoint == null) return false;
        _rentalPoints.Remove(deletedRentalPoint);
        return true;
    }
}
