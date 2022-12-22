var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.Run(async (HttpContext context) => {
    context.Response.Headers["Chave"] = "Valor da Chave";
    context.Response.Headers["Content-Type"] = "text/html";
    await context.Response.WriteAsync("<h2>Hello World!</h2>");
});

app.Run();
