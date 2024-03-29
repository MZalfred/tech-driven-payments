using Microsoft.AspNetCore.Mvc;
using QuickPay.Models;

namespace QuickPay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentsController : ControllerBase
    {
        [HttpPost]
        public IActionResult ProcessPayment([FromBody] Payment payment)
        {
            // For now, just return a simple message
            return Ok($"Payment for {payment.Amount} {payment.Currency} to {payment.Recipient} processed.");
        }
    }
}
