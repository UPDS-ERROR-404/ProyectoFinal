public class Ticket
{
    public int Id { get; set; }
    public string Plate { get; set; } = null!;
    public int ParkingSpotId { get; set; }
    public DateTime CheckIn { get; set; } = DateTime.Now;
    public DateTime? CheckOut { get; set; }
    public decimal? Amount { get; set; }
}

public class ParkingSpot
{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public SpotStatus Status { get; set; } = SpotStatus.Free;
}
public enum SpotStatus { Free, Occupied, Reserved }