using backend.Data;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using backend.Hubs;


var builder = WebApplication.CreateBuilder(args);

// SERVICES
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDistributedMemoryCache(); // 🔥 REQUIRED

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});



// ✅ SignalR
builder.Services.AddSignalR();

// ✅ CORS
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowAll", policy =>
//    {
//        policy
//            .AllowAnyHeader()
//            .AllowAnyMethod()
//            .AllowAnyOrigin();// OK for now (development)

//    });
//});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy
            .WithOrigins("http://localhost:5271") // your frontend URL
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();   // 🔥 REQUIRED FOR SESSION
    });
});


builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("MySqlConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySqlConnection"))
    ));

var app = builder.Build(); ;

// MIDDLEWARE
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseDefaultFiles();
// ✅ Static files (for index.html, css, js)
app.UseStaticFiles();

// ✅ CORS MUST BE BEFORE hubs & controllers
app.UseCors("AllowAll");

// ✅ MAP HUB AFTER CORS
app.MapHub<OrderHub>("/orderHub");

app.UseRouting();
app.UseSession();
app.UseAuthorization();



// ✅ MAP CONTROLLERS
app.MapControllers();




app.Run();
