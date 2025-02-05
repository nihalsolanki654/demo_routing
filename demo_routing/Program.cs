var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
 
//app.MapGet("/", () => "Hello World!");      using only mapget we can write only one lines of logic
//app.Map("/Home", () => "welcome to istar");
//app.MapGet("/home", () => "Hello World!");

//app.MapPost("/home", () => "Hello World!  -- HTTP Post request");
//app.MapPut("/home", () => "Hello World!  -- HTTP Put request");
//app.MapDelete("/home", () => "Hello World!  -- HTTP Delete request");
//app.MapGet("/home", () => "Hello World!  -- HTTP Get request");

app.UseRouting();
app.UseEndpoints(static endpoints => 
{
    endpoints.MapGet("/home", async  (Context) =>   // using endpoints we can write multiple lines of logic
    {
        await Context.Response.WriteAsync("this is my home page for get\n");
        await Context.Response.WriteAsync("this is my home page ");
    });

    endpoints.MapPost("/home", async (Context) =>   // using endpoints we can write multiple lines of logic
    {
        await Context.Response.WriteAsync("this is my home page for post\n");
        await Context.Response.WriteAsync("this is my home page ");
    });

    endpoints.MapPut("/home", async (Context) =>   // using endpoints we can write multiple lines of logic
    {
        await Context.Response.WriteAsync("this is my home page for put\n");
        await Context.Response.WriteAsync("this is my home page ");
    });

    endpoints.MapDelete("/home", async (Context) =>   // using endpoints we can write multiple lines of logic
    {
        await Context.Response.WriteAsync("this is my home page for delete\n");
        await Context.Response.WriteAsync("this is my home page ");
    });

});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("page not found ");
});

app.Run();
