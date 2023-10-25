using Sharedboard_SignalR.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});
var app = builder.Build();

app.UseDeveloperExceptionPage();

app.UseDefaultFiles();

app.UseStaticFiles();

app.UseCors("CorsPolicy");

app.UseRouting();

app.MapHub<DrawHub>("/dashboard");

app.Run();
