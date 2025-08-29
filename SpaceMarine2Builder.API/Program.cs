using SpaceMarine2Builder.API.DAOs;
using SpaceMarine2Builder.API.DTOs;
using SpaceMarine2Builder.API.Managers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDataStorageManager, DataStorageManager>();
builder.Services.AddScoped<IDataStorageAccess, DataStorageAccess>();

builder.Services.AddCors(options =>
{
	options.AddPolicy("BlazorAppPolicy", policy =>
	{
		policy.WithOrigins("https://localhost:7149") // replace with your Blazor HTTPS port
			  .AllowAnyHeader()
			  .AllowAnyMethod();
	});
});




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("BlazorAppPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
