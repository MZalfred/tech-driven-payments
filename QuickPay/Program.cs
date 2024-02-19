var builder = WebApplication.CreateBuilder(args);
// Add services and middleware configurations...

var app = builder.Build();
// Configure the HTTP request pipeline...

// Endpoint definitions...
app.MapPost("/processpayment", (QuickPay.Models.Payment payment) =>
{
    // Endpoint logic using the Payment class from Models/Payment.cs
    // Remember to add using QuickPay.Models; at the top if using namespaces
});

app.Run();
