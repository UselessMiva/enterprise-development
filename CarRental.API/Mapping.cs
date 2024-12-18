using AutoMapper;
using CarRental.API.DTO;
using CarRental.Domain;

namespace CarRental.API;

public class Mapping: Profile
{
    public Mapping()
    {
        CreateMap<CarOnRent, CarOnRentGetDTO>().ReverseMap();
        CreateMap<CarOnRent, CarOnRentPostDTO>().ReverseMap();
        CreateMap<Vehicle,VehicleGetDTO>().ReverseMap();
        CreateMap<Vehicle, VehiclePostDTO>();
        CreateMap<RentalClient, RentalClientGetDTO>().ReverseMap();
        CreateMap<RentalClient, RentalClientPostDTO>().ReverseMap();
        CreateMap<RentalPoint, RentalPointGetDTO>().ReverseMap();
        CreateMap<RentalPoint, RentalPointPostDTO>().ReverseMap();
        CreateMap<RentalPoint, RentalPointGetDTO>().ReverseMap();
        CreateMap<RentalPoint, RentalPointPostDTO>().ReverseMap();
    }
}
