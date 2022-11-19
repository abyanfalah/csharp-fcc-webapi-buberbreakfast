using BuberBreakfast.Service;

var builder = WebApplication.CreateBuilder(args);
{
	builder.Services.AddControllers();
	builder.Services.AddScoped<IBreakfastService, BreakfastService>();
	builder.Services.AddScoped<IUserService, UserService>();
}

var app = builder.Build();
{
	app.UseHttpsRedirection();
	app.MapControllers();
	app.Run();
}

