var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/shirts", () =>
{
    return "Reading all the shirts";
});

app.MapGet("/shirts/{id}", (int id) =>
{
    return $"Reading shirts with ID:{id}";
});

app.MapPost("/shirts", () =>
{
    return "Creating new shirts";
});

app.MapPut("/shirts/{id}", (int id) =>
{
    return $"Updating shirts with ID:{id}";
});

app.MapDelete("/shirts/{id}", (int id) =>
{
    return $"Deleting shirts with ID:{id}";
});

app.Run();