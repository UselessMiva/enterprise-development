using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CarRental.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "rental_client",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    passport = table.Column<string>(type: "text", nullable: true),
                    full_name = table.Column<string>(type: "text", nullable: true),
                    birth_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rental_client", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rental_point",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    address = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rental_point", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vehicle",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    car_number = table.Column<string>(type: "text", nullable: true),
                    model = table.Column<string>(type: "text", nullable: true),
                    color = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicle", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cars_on_rent",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    vehicle = table.Column<int>(type: "integer", nullable: true),
                    rental_client = table.Column<int>(type: "integer", nullable: true),
                    rental_point_get_from = table.Column<int>(type: "integer", nullable: true),
                    rental_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    return_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    rental_duration = table.Column<TimeSpan>(type: "interval", nullable: true),
                    rental_point_return_to = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars_on_rent", x => x.id);
                    table.ForeignKey(
                        name: "FK_cars_on_rent_rental_client_rental_client",
                        column: x => x.rental_client,
                        principalTable: "rental_client",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cars_on_rent_rental_point_rental_point_get_from",
                        column: x => x.rental_point_get_from,
                        principalTable: "rental_point",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cars_on_rent_rental_point_rental_point_return_to",
                        column: x => x.rental_point_return_to,
                        principalTable: "rental_point",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cars_on_rent_vehicle_vehicle",
                        column: x => x.vehicle,
                        principalTable: "vehicle",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cars_on_rent_rental_client",
                table: "cars_on_rent",
                column: "rental_client");

            migrationBuilder.CreateIndex(
                name: "IX_cars_on_rent_rental_point_get_from",
                table: "cars_on_rent",
                column: "rental_point_get_from");

            migrationBuilder.CreateIndex(
                name: "IX_cars_on_rent_rental_point_return_to",
                table: "cars_on_rent",
                column: "rental_point_return_to");

            migrationBuilder.CreateIndex(
                name: "IX_cars_on_rent_vehicle",
                table: "cars_on_rent",
                column: "vehicle");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cars_on_rent");

            migrationBuilder.DropTable(
                name: "rental_client");

            migrationBuilder.DropTable(
                name: "rental_point");

            migrationBuilder.DropTable(
                name: "vehicle");
        }
    }
}
