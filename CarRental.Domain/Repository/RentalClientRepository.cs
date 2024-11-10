using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRental.Domain.Repository;

public class RentalClientRepository() : IRentalClientRepository
{
    private static readonly List<RentalClient> _rentalclients = [];
    /// <inheritdoc />
    public List<RentalClient> GetAll() =>  _rentalclients;


    /// <inheritdoc />  
    public RentalClient? Get(int id) =>  _rentalclients.Find(d => d.Id == id);

    /// <inheritdoc />
    public void Post(RentalClient newObj)
    {
        newObj.Id =  _rentalclients.Count;
         _rentalclients.Add(newObj);
    }

    /// <inheritdoc />
    public bool Put(RentalClient newObj, int id)
    {
        var oldRentalClient = Get(id);
        if (oldRentalClient == null) return false;
        oldRentalClient.Id = newObj.Id;
        oldRentalClient.Passport = newObj.Passport;
        oldRentalClient.FullName = newObj.FullName;
        return true;
    }

    /// <inheritdoc />
    public bool Delete(int id)
    {
        var deletedRentalClient = Get(id);
        if (deletedRentalClient == null) return false;
         _rentalclients.Remove(deletedRentalClient);
        return true;
    }
}
