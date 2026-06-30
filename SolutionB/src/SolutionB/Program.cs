var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new
{
    solution = "SolutionB",
    message = Common.BuildInfo.GetSharedMessage("SolutionB")
});

app.MapGet("/health", () => Results.Ok(new { status = "healthy", solution = "SolutionB" }));

app.Run();
