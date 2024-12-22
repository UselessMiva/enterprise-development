using Microsoft.EntityFrameworkCore;

namespace CarRental.Domain;

public class CarRentalServiceContext : DbContext
{
    public CarRentalServiceContext(DbContextOptions<CarRentalServiceContext> options)
        : base(options)
    {

    }

    public DbSet<CarOnRent> CarsOnRent { get; set; }
    public DbSet<RentalClient> RentalClients { get; set; }
    public DbSet<RentalPoint> RentalPoints { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<CarOnRent>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            entity.HasOne(e => e.Vehicle)
                .WithMany()
                .HasForeignKey("vehicle");

            entity.HasOne(e => e.Client)
                .WithMany()
                .HasForeignKey("rental_client");

            entity.HasOne(e => e.RentalPointGetFrom)
                .WithMany()
                .HasForeignKey("rental_point_get_from");

            entity.HasOne(e => e.RentalPointReturnTo)
                .WithMany()
                .HasForeignKey("rental_point_return_to");

            entity.ToTable("cars_on_rent");
        });
    }

}