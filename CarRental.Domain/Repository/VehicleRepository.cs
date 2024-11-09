namespace CarRental.Domain.Repository;

///// <summary>
/////     Класс реализует интерфейс <see cref="IVehicleRepository" />
///// </summary>
//public class VehicleRepository(Vehicle context) : IVehicleRepository
//{
//    /// <inheritdoc />
//    public IEnumerable<Vehicle> GetAll()
//    {
//        return context.Vehicles;
//    }

//    /// <inheritdoc />
//    public Vehicle? GetById(int id)
//    {
//        return context.Vehicles.Find(id);
//    }

//    /// <inheritdoc />
//    public Vehicle Create(Vehicle entity)
//    {
//        var res = context.Vehicles.Add(entity).Entity;
//        context.SaveChanges();
//        return res;
//    }

//    /// <inheritdoc />
//    public Vehicle Update(Vehicle entity)
//    {
//        var entry = context.Entry(entity);
//        entry.State = EntityState.Modified;
//        context.SaveChanges();
//        return entry.Entity;
//    }

//    /// <inheritdoc />
//    public void Delete(Vehicle entity)
//    {
//        context.Vehicles.Remove(entity);
//        context.SaveChanges();
//    }
//}
