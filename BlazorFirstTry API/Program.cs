using BlazorFirstTry_API.Data;
using BlazorFirstTry_API.Repositories;
using BlazorFirstTry_API.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);
 
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContextPool<ShopOnlineDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ShopOnlineConnection"))
    );
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(policy =>
policy.WithOrigins("https://localhost:7265", "http://localhost:7265")
.AllowAnyMethod()
 .WithHeaders(HeaderNames.ContentType)

);


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
