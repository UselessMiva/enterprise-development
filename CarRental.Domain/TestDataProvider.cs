namespace CarRental.Domain;

public class TestDataProvider
{
    public List<Vehicle> vehicles =
    [
        new( 1, "Number 1", "Model 1", "Color 1" ),
        new( 2, "Number 2", "Model 2", "Color 2" ),
        new( 3, "Number 3", "Model 3", "Color 3" ),
        new( 4, "Number 4", "Model 4", "Color 4" ),
        new( 5, "Number 5", "Model 5", "Color 5" ),
        new( 6, "Number 6", "Model 6", "Color 6" ),
        new( 7, "Number 7", "Model 7", "Color 7" )
    ];

    public List<RentalPoint> rentalPoints =
    [
        new( 1, "Name 1", "Address 1" ),
        new( 2, "Name 2", "Address 2" ),
        new( 3, "Name 3", "Address 3" ),
        new( 4, "Name 4", "Address 4" ),
        new( 5, "Name 5", "Address 5" ),
        new( 6, "Name 6", "Address 6" )
    ];

    public List<RentalClient> clients =
    [
        new ( 1, "Passport 1", "Full Name 1", new DateTime(1991, 1, 1) ),
        new ( 2, "Passport 2", "Full Name 2", new DateTime(1992, 2, 2) ),
        new ( 3, "Passport 3", "Full Name 3", new DateTime(1993, 3, 3) ),
        new ( 4, "Passport 4", "Full Name 4", new DateTime(1994, 4, 4) ),
        new ( 5, "Passport 5", "Full Name 5", new DateTime(1995, 5, 5) )
    ];

    public List<CarOnRent> vehiclesOnRent;

    public TestDataProvider() => vehiclesOnRent =
        [
            new(
                1,
                vehicles[2],
                clients[3],
                rentalPoints[0],
                DateTime.Now.AddDays(-5),
                TimeSpan.FromDays(2),
                DateTime.Now.AddDays(-3),
                rentalPoints[4]
            ),
            new(
                2,
                vehicles[3],
                clients[4],
                rentalPoints[2],
                DateTime.Now.AddDays(-3),
                TimeSpan.FromDays(1),
                DateTime.Now.AddDays(-2),
                rentalPoints[3]
            ),
            new(
                3,
                vehicles[3],
                clients[2],
                rentalPoints[2],
                DateTime.Now.AddDays(-3),
                TimeSpan.FromDays(2),
                DateTime.Now.AddDays(-1),
                rentalPoints[5]
            ),
            new(
                4,
                vehicles[4],
                clients[3],
                rentalPoints[0],
                DateTime.Now.AddDays(-2),
                TimeSpan.FromDays(2),
                DateTime.Now,
                rentalPoints[4]
            ),
            new(
                5,
                vehicles[4],
                clients[4],
                rentalPoints[5],
                DateTime.Now.AddDays(-3),
                TimeSpan.FromDays(2),
                DateTime.Now.AddDays(-1),
                rentalPoints[2]
            ),
            new(
                6,
                vehicles[4],
                clients[1],
                rentalPoints[2],
                DateTime.Now.AddDays(-5),
                TimeSpan.FromDays(3),
                DateTime.Now.AddDays(-2),
                rentalPoints[3]
            ),
            new(
                7,
                vehicles[5],
                clients[2],
                rentalPoints[1],
                DateTime.Now.AddDays(-4),
                TimeSpan.FromDays(4),
                DateTime.Now,
                rentalPoints[2]
            ),
            new(
                8,
                vehicles[5],
                clients[0],
                rentalPoints[2],
                DateTime.Now.AddDays(-2),
                TimeSpan.FromDays(2),
                DateTime.Now,
                rentalPoints[2]
            ),
            new(
                9,
                vehicles[5],
                clients[3],
                rentalPoints[2],
                DateTime.Now.AddDays(-3),
                TimeSpan.FromDays(3),
                DateTime.Now,
                rentalPoints[3]
            ),
            new(
                10,
                vehicles[5],
                clients[4],
                rentalPoints[3],
                DateTime.Now.AddDays(-2),
                TimeSpan.FromDays(2),
                DateTime.Now,
                rentalPoints[2]
            ),
            new(
                11,
                vehicles[6],
                clients[3],
                rentalPoints[1],
                DateTime.Now.AddDays(-2),
                TimeSpan.FromDays(2),
                DateTime.Now,
                rentalPoints[2]
            ),
            new(
                12,
                vehicles[6],
                clients[2],
                rentalPoints[2],
                DateTime.Now.AddDays(-10),
                TimeSpan.FromDays(5),
                DateTime.Now.AddDays(-5),
                rentalPoints[3]
            ),
            new(
                13,
                vehicles[6],
                clients[4],
                rentalPoints[4],
                DateTime.Now.AddDays(-2),
                TimeSpan.FromDays(2),
                DateTime.Now,
                rentalPoints[5]
            ),
            new(
                14,
                vehicles[6],
                clients[1],
                rentalPoints[5],
                DateTime.Now.AddDays(-6),
                TimeSpan.FromDays(4),
                DateTime.Now.AddDays(-2),
                rentalPoints[5]
            ),
            new(
                15,
                vehicles[6],
                clients[0],
                rentalPoints[5],
                DateTime.Now.AddDays(-8),
                TimeSpan.FromDays(4),
                DateTime.Now.AddDays(-4),
                rentalPoints[2]
            ),
            new(
                16,
                vehicles[6],
                clients[2],
                rentalPoints[2],
                DateTime.Now.AddDays(-4),
                TimeSpan.FromDays(7)
            ),
            new(
                17,
                vehicles[5],
                clients[1],
                rentalPoints[5],
                DateTime.Now.AddDays(-4),
                TimeSpan.FromDays(7)
            ),
            new(
                18,
                vehicles[4],
                clients[3],
                rentalPoints[3],
                DateTime.Now.AddDays(-4),
                TimeSpan.FromDays(7)
            ),
            new(
                19,
                vehicles[3],
                clients[4],
                rentalPoints[2],
                DateTime.Now.AddDays(-4),
                TimeSpan.FromDays(7)
            ),
            new(
                20,
                vehicles[2],
                clients[1],
                rentalPoints[4],
                DateTime.Now.AddDays(-4),
                TimeSpan.FromDays(7)
            ),
            new(
                21,
                vehicles[1],
                clients[2],
                rentalPoints[2],
                DateTime.Now.AddDays(-4),
                TimeSpan.FromDays(7)
            ),
            new(
                22,
                vehicles[0],
                clients[1],
                rentalPoints[2],
                DateTime.Now.AddDays(-4),
                TimeSpan.FromDays(7)
            ),
        ];
}


