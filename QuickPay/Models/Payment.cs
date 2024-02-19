public class Payment
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string? Currency { get; set; } // Now explicitly nullable
    public string? Recipient { get; set; } // Now explicitly nullable
}
