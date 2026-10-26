var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy => policy.WithOrigins(
                            "http://localhost:4200", 
                            "https://salmon-sand-09269c10f3.azurestaticapps.net"
                        )
                        .AllowAnyHeader()
                        .AllowAnyMethod());
});

var app = builder.Build();


app.UseRouting();           // 1. Roteamento primeiro
app.UseCors("AllowAngular"); // 2. CORS depois do roteamento
app.UseAuthorization();     // 3. Autorização depois do CORS

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();