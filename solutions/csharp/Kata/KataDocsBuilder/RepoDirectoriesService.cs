namespace KataDocsBuilder;
class RepoDirectoriesService
{
    private const string KyuDirectoryPattern = "*-kyu";
    private const string RepositoryReadmeDirectory = "docs";

    public RepoDirectoriesService(string launchDirectory)
    {
        SolutionDirectory = Path.GetFullPath(Path.Combine(launchDirectory, "..", "..", "..", ".."));
        RepositoryDocsDirectory = Path.GetFullPath(Path.Combine(SolutionDirectory, "..", RepositoryReadmeDirectory));
        KyuDirectories = Directory.GetDirectories(SolutionDirectory, KyuDirectoryPattern, SearchOption.AllDirectories);

        if (KyuDirectories is null || KyuDirectories?.Length == 0)
            throw new InvalidOperationException("No kyu directories were found");
    }

    internal string SolutionDirectory { get; init; }

    internal string RepositoryDocsDirectory { get; init; }

    internal string[] KyuDirectories { get; init; } = [];
}
