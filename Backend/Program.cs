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

// A ORDEM AQUI É CRUCIAL:
app.UseRouting();

app.UseCors("AllowAngular"); // 2. Aplica o CORS DEPOIS do roteamento

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization(); // 3. Autorização (se necessário)

app.MapControllers(); // 4. Mapeia os controllers

app.Run();