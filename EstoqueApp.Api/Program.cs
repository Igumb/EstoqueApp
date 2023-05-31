using EstoqueApp.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRouting(map => map.LowercaseUrls = true);
builder.Services.AddControllers();
builder.Services.AddSwaggerDoc();
builder.Services.AddCorsPolicy();
builder.Services.AddEntityFramework(builder.Configuration);
builder.Services.AddServices(builder.Configuration);
builder.Services.AddMediatR();

var app = builder.Build();

app.UseSwaggerDoc();
app.UseCorsPolicy();
app.UseAuthorization();
app.MapControllers();

app.Run();



