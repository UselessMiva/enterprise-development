using Microsoft.EntityFrameworkCore;

namespace CarRental.Domain;

public class CarRentalServiceContext : DbContext // Исправлено: добавлен двоеточие для наследования
{
    public CarRentalServiceContext(DbContextOptions<CarRentalServiceContext> options)
        : base(options) // Исправлено: правильный вызов базового конструктора
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
                .HasForeignKey("vehicle")
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(e => e.Client)
                .WithMany()
                .HasForeignKey("rental_client")
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(e => e.RentalPointGetFrom)
                .WithMany()
                .HasForeignKey("rental_point_get_from")
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(e => e.RentalPointReturnTo)
                .WithMany()
                .HasForeignKey("rental_point_return_to")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            entity.Property(e => e.RentalTime)
                .HasColumnName("rental_time")
                .IsRequired(false);

            entity.Property(e => e.ReturnTime)
                .HasColumnName("return_time")
                .IsRequired(false);

            entity.Property(e => e.RentalDuration)
                .HasColumnName("rental_duration")
                .IsRequired(false);

            entity.ToTable("cars_on_rent");
        });
    }

}