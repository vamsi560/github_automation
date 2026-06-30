var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new
{
    solution = "SolutionA",
    message = Common.BuildInfo.GetSharedMessage("SolutionA")
});

app.MapGet("/health", () => Results.Ok(new { status = "healthy", solution = "SolutionA" }));

app.Run();
