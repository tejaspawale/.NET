using InsuranceAPI.Managers;
using InsuranceAPI.Models;
using InsuranceAPI.Notification;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

PolicyManager manager = new PolicyManager();
Notifications notify = new Notifications();

manager.Purchased += notify.ShowNotification;



app.MapPost("/policy", (Policy policy) =>
{
    manager.AddPolicy(policy);

    return Results.Ok("Policy Added");
});

app.MapGet("/api/policy", () =>
{
    return Results.Ok(manager.GetAllPolicies());
});

app.Run();