namespace MabeyaECommerce.Domain;


public class VisitLog
{
    public Guid Id { get; set; }
    public string? UserId { get; set; }   // null = guest
    public string SessionId { get; set; } = null!;
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public int DurationSec { get; set; }  // saniye

}
