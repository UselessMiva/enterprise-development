using AutoMapper;
using CarRental.API.DTO;
using CarRental.Domain;

namespace CarRental.API;

public class Mapping: Profile
{
    public Mapping()
    {
        CreateMap<Vehicle,VehicleDTO>().ReverseMap();
        CreateMap<RentalClient, RentalClientDTO>().ReverseMap();
        CreateMap<RentalPoint, RentalPointDTO>().ReverseMap();
        CreateMap<CarOnRent, CarOnRentDTO>().ReverseMap();
    }
}
