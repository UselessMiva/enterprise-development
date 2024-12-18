using System.Reflection;
using CarRental.API;
using CarRental.API.Services;
using CarRental.Domain.Repository;
using CarRental.Domain;
using CarRental.API.DTO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

builder.Services.AddSingleton<IRepository<CarOnRent>, CarOnRentRepository>();
builder.Services.AddSingleton<IRepository<RentalClient>, RentalClientRepository>();
builder.Services.AddSingleton<IRepository<RentalPoint>, RentalPointRepository>();
builder.Services.AddSingleton<IRepository<Vehicle>, VehicleRepository>();

builder.Services.AddSingleton<IService<CarOnRentGetDTO, CarOnRentPostDTO>, CarOnRentService>();
builder.Services.AddSingleton<IService<RentalClientGetDTO, RentalClientPostDTO>, RentalClientService>();
builder.Services.AddSingleton<IService<RentalPointGetDTO, RentalPointPostDTO>, RentalPointService>();
builder.Services.AddSingleton<IService<VehicleGetDTO, VehiclePostDTO>, VehicleService>();
builder.Services.AddSingleton<IRequestService, RequestService>();
builder.Services.AddSingleton<TestDataProvider>();

builder.Services.AddAutoMapper(typeof(Mapping));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
