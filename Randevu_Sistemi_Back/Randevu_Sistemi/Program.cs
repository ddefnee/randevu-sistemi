using Microsoft.EntityFrameworkCore;
using Randevu_Sistemi.Data;
using Randevu_Sistemi.Data; // 👈 Proje adına göre değişebilir

var builder = WebApplication.CreateBuilder(args);

// 🔹 DbContext – SQL Server bağlantısı
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

// 🔹 Controller & Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🔹 CORS – Angular bağlantısı için
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// 🔹 Swagger (Development ortamı)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// 🔹 CORS aktif
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
