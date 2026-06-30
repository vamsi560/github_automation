namespace Common;

public static class BuildInfo
{
    public static string GetSharedMessage(string solutionName)
    {
        return $"Shared dependency loaded for {solutionName} at {DateTimeOffset.UtcNow:O}";
    }
}
