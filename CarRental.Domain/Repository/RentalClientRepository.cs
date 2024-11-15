using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarRental.Domain.Repository;

public class RentalClientRepository() : IRepository<RentalClient>
{
    private static readonly List<RentalClient> _rentalclients = [];
    
    public List<RentalClient> GetAll() =>  _rentalclients;
 
    public RentalClient? Get(int id) =>  _rentalclients.Find(d => d.Id == id);
   
    public RentalClient Post(RentalClient newObj)
    {
         _rentalclients.Add(newObj);
        return newObj;
    }

    public bool Put(RentalClient newObj, int id)
    {
        var oldRentalClient = Get(id);
        if (oldRentalClient == null) return false;
        oldRentalClient.Id = newObj.Id;
        oldRentalClient.Passport = newObj.Passport;
        oldRentalClient.FullName = newObj.FullName;
        return true;
    }

    public bool Delete(int id)
    {
        var deletedRentalClient = Get(id);
        if (deletedRentalClient == null) return false;
         _rentalclients.Remove(deletedRentalClient);
        return true;
    }
}
