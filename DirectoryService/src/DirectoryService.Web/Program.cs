using DirectoryService.Application;
using DirectoryService.Application.Database;
using DirectoryService.Infrastructure.Postgres;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();

builder.Services.AddScoped<DirectoryServiceDbContext>
    ( _ =>  new DirectoryServiceDbContext(builder.Configuration.GetConnectionString("DirectoryServiceDb")!));

builder.Services.AddScoped<IReservationServiceDbContext, DirectoryServiceDbContext>
    ( _ =>  new DirectoryServiceDbContext(builder.Configuration.GetConnectionString("DirectoryServiceDb")!));

builder.Services.AddScoped<CreateLocationHandler>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json", "DirectoryService"));
}
app.MapControllers();
app.Run();
