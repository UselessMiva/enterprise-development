﻿// <auto-generated />
using System;
using CarRental.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CarRental.Domain.Migrations
{
    [DbContext(typeof(CarRentalServiceContext))]
    partial class CarRentalServiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CarRental.Domain.CarOnRent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<TimeSpan?>("RentalDuration")
                        .HasColumnType("interval")
                        .HasColumnName("rental_duration");

                    b.Property<DateTime?>("RentalTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("rental_time");

                    b.Property<DateTime?>("ReturnTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("return_time");

                    b.Property<int?>("rental_client")
                        .HasColumnType("integer");

                    b.Property<int?>("rental_point_get_from")
                        .HasColumnType("integer");

                    b.Property<int?>("rental_point_return_to")
                        .HasColumnType("integer");

                    b.Property<int?>("vehicle")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("rental_client");

                    b.HasIndex("rental_point_get_from");

                    b.HasIndex("rental_point_return_to");

                    b.HasIndex("vehicle");

                    b.ToTable("cars_on_rent", (string)null);
                });

            modelBuilder.Entity("CarRental.Domain.RentalClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("birth_date");

                    b.Property<string>("FullName")
                        .HasColumnType("text")
                        .HasColumnName("full_name");

                    b.Property<string>("Passport")
                        .HasColumnType("text")
                        .HasColumnName("passport");

                    b.HasKey("Id");

                    b.ToTable("rental_client");
                });

            modelBuilder.Entity("CarRental.Domain.RentalPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("rental_point");
                });

            modelBuilder.Entity("CarRental.Domain.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CarNumber")
                        .HasColumnType("text")
                        .HasColumnName("car_number");

                    b.Property<string>("Color")
                        .HasColumnType("text")
                        .HasColumnName("color");

                    b.Property<string>("Model")
                        .HasColumnType("text")
                        .HasColumnName("model");

                    b.HasKey("Id");

                    b.ToTable("vehicle");
                });

            modelBuilder.Entity("CarRental.Domain.CarOnRent", b =>
                {
                    b.HasOne("CarRental.Domain.RentalClient", "Client")
                        .WithMany()
                        .HasForeignKey("rental_client")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CarRental.Domain.RentalPoint", "RentalPointGetFrom")
                        .WithMany()
                        .HasForeignKey("rental_point_get_from")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CarRental.Domain.RentalPoint", "RentalPointReturnTo")
                        .WithMany()
                        .HasForeignKey("rental_point_return_to")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CarRental.Domain.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("vehicle")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Client");

                    b.Navigation("RentalPointGetFrom");

                    b.Navigation("RentalPointReturnTo");

                    b.Navigation("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}
