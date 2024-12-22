using System.Reflection;
using CarRental.API;
using CarRental.API.Services;
using CarRental.Domain.Repository;
using CarRental.Domain;
using CarRental.API.DTO;
using Microsoft.EntityFrameworkCore;

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

builder.Services.AddScoped<IRepository<CarOnRent>, CarOnRentRepository>();
builder.Services.AddScoped<IRepository<RentalClient>, RentalClientRepository>();
builder.Services.AddScoped<IRepository<RentalPoint>, RentalPointRepository>();
builder.Services.AddScoped<IRepository<Vehicle>, VehicleRepository>();

builder.Services.AddScoped<IService<CarOnRentGetDTO, CarOnRentPostDTO>, CarOnRentService>();
builder.Services.AddScoped<IService<RentalClientGetDTO, RentalClientPostDTO>, RentalClientService>();
builder.Services.AddScoped<IService<RentalPointGetDTO, RentalPointPostDTO>, RentalPointService>();
builder.Services.AddScoped<IService<VehicleGetDTO, VehiclePostDTO>, VehicleService>();
builder.Services.AddScoped<IRequestService, RequestService>();
builder.Services.AddSingleton<TestDataProvider>();

builder.Services.AddDbContext<CarRentalServiceContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("Postgre")
    ));
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
