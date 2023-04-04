using SportsStore.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
//builder.Services.AddMvc();

builder.Services.AddSingleton<IRepository,DataRepository>();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");        ?????

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseMvcWithDefaultRoute();
app.Run();
