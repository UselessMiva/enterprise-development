using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRental.Domain.Repository;

//public class RentalPointRepository(RentalPoint context) : IRentalPointRepository
//{

//    /// <inheritdoc />
//    public IEnumerable<RentalPoint> GetAll()
//    {
//        return context.RentalPoints;
//    }

//    /// <inheritdoc />
//    public RentalPoint? GetById(int id)
//    {
//        return context.RentalPoints.Find(id);
//    }

//    /// <inheritdoc />
//    public RentalPoint Create(RentalPoint entity)
//    {
//        var res = context.RentalPoints.Add(entity).Entity;
//        context.SaveChanges();
//        return res;
//    }

//    /// <inheritdoc />
//    public RentalPoint Update(RentalPoint entity)
//    {
//        var entry = context.Entry(entity);
//        entry.State = EntityState.Modified;
//        context.SaveChanges();
//        return entry.Entity;
//    }

//    /// <inheritdoc />
//    public void Delete(RentalPoint entity)
//    {
//        context.RentalPoints.Remove(entity);
//        context.SaveChanges();
//    }
//}
