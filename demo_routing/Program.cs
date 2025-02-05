var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.Map("/Home", () => "welcome to istar");
//app.MapGet("/home", () => "Hello World!");

//app.MapPost("/home", () => "Hello World!  -- HTTP Post request");
//app.MapPut("/home", () => "Hello World!  -- HTTP Put request");
//app.MapDelete("/home", () => "Hello World!  -- HTTP Delete request");
//app.MapGet("/home", () => "Hello World!  -- HTTP Get request");

app.UseRouting();


app.Run();
