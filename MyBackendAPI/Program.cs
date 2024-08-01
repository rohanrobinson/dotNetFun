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

app.MapGet("/", () => "welcome to let's go biotech. learn from cutting-edge biotech papers and companies");

app.MapGet("/about", () => "about let's go biotech");

app.MapGet("/companyList", () => "list of interesting biotech companies");

app.MapGet("/paperList", () => "list of interesting biotech papers");

app.Run();




