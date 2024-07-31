var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/", () => {
    var creatorName = "Rohan Cain Robinson created this";
    var htmlContent = $@"
        <!DOCTYPE html>
        <html lang=""en"">
        <head>
            <meta charset=""UTF-8"">
            <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
            <title>Creator Information</title>
        </head>
        <body>
            <h1>{creatorName}</h1>
        </body>
        </html>
    ";
    return Results.Content(htmlContent, "text/html");
});

app.MapGet("/friends", () => new[]
{
    new Friend("Anya"), new Friend("Eshaan"), new Friend("Anna")
});

app.Run();

record Friend(string friendName);



