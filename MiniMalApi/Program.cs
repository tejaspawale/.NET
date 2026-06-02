var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string[] cars = ["Volvo", "BMW", "Ford", "Mazda"];

app.MapGet("/", () =>
{
    return "Hello Tejas!";
});

app.MapGet("/api/cars", () =>
{
    return Results.Ok(cars);
});

app.MapGet("/api/cars/{index}", (int index) =>
{
    return Results.Ok(cars[index]);
});



app.Run();