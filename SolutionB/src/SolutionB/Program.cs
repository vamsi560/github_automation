var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new
{
    solution = "SolutionB",
    version = "v2",
    message = Common.BuildInfo.GetSharedMessage("SolutionB"),
    note = "This change is scoped to SolutionB only."
});

app.MapGet("/health", () => Results.Ok(new { status = "healthy", solution = "SolutionB", version = "v2" }));
app.MapGet("/build", () => Results.Ok(new { solution = "SolutionB", version = "v2" }));

app.Run();
