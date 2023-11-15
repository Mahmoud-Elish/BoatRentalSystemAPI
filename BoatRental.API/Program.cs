using BoatRental.DAL;
using Microsoft.EntityFrameworkCore;
using System.Threading.RateLimiting;

var builder = WebApplication.CreateBuilder(args);

#region Default
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#endregion

#region DbConnectionString

builder.Services.AddDbContext<BoatRentalContext>(option =>
                option.UseSqlServer(builder.Configuration.GetConnectionString("BoatRentalDB")));

#endregion

#region InjectionForRepositories
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IBoatRepo, BoatRepo>();
builder.Services.AddScoped<IBookingRepo, BookingRepo>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
