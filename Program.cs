var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();
app.MapGet("/", () => Results.Redirect("/Test.html"));

app.Run();
