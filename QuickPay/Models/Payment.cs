namespace QuickPay.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string? Currency { get; set; }
        public string? Recipient { get; set; }
    }
}
