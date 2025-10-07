using System.Reflection;
using System.Text;

namespace KataDocsBuilder;

public partial class DocsBuilder
{
    const string ReadmeFile = "README.md";

    public static void BuildReadmeFile(string launchDirectory)
    {
        var dirService = new RepoDirectoriesService(launchDirectory);
        var map = new SortedDictionary<string, SortedDictionary<string, string>>();
        var statisticsMap = new SortedDictionary<string, int>();

        foreach (var kyuDir in dirService.KyuDirectories)
            HandleKyuDirectory(kyuDir, map, statisticsMap);

        RecreateSolutionReadmeFile(dirService, map);
        AddStatistics(dirService, statisticsMap);
    }

    private static void RecreateSolutionReadmeFile(RepoDirectoriesService directoriesService, SortedDictionary<string, SortedDictionary<string, string>> map)
    {
        var filePath = Path.Combine(directoriesService.SolutionDirectory, ReadmeFile);
        CreateAndWriteFile(filePath, map);
    }

    private static void AddStatistics(RepoDirectoriesService directoriesService, SortedDictionary<string, int> statisticsMap)
    {
        if (!Directory.Exists(directoriesService.RepositoryDocsDirectory))
            Directory.CreateDirectory(directoriesService.RepositoryDocsDirectory);

        var mainReadmePath = Path.Combine(directoriesService.RepositoryDocsDirectory, ReadmeFile);
        if (!File.Exists(mainReadmePath))
            File.Create(mainReadmePath);

        var readmeStart = ReadResourceText($"{typeof(DocsBuilder).Namespace}.Resources.ReadmeStart.md");
        var readmeEnd = ReadResourceText($"{typeof(DocsBuilder).Namespace}.Resources.ReadmeEnd.md");

        var statistics = BuildStatistics(statisticsMap);

        var mainReadme = new StringBuilder();
        mainReadme.AppendLine(readmeStart);
        mainReadme.AppendLine();
        mainReadme.AppendLine(statistics);
        mainReadme.AppendLine();
        mainReadme.AppendLine(readmeEnd);

        File.WriteAllText(mainReadmePath, mainReadme.ToString(), Encoding.UTF8);
    }

    private static string GetStatisticsColumnHeader(string indexFilePath)
    {
        var kyuNumber = new DirectoryInfo(Path.GetDirectoryName(indexFilePath) ?? string.Empty).Name;
        var kyuUri = GetKyuIndexUri(indexFilePath);
        return $" [{kyuNumber}]({kyuUri}) ";
    }

    private static string GetKyuIndexUri(string indexFilePath)
    {
        var directoryName = Path.GetDirectoryName(indexFilePath) ?? string.Empty;
        Uri uri = new Uri(directoryName);
        if (uri.Segments.Length < 3)
            throw new ArgumentException($"Incorrect directory location before the main {ReadmeFile} file");
        var separator = '/';
        var gitPath = new StringBuilder($"..{separator}");
        gitPath = gitPath
            .Append(string.Concat(uri.Segments.Skip(uri.Segments.Length - 3)))
            .Append(separator)
            .Append(Path.GetFileName(indexFilePath));
        return gitPath.ToString();
    }

    private static string GetHeaderLineSeparator(string header) =>
        $":{new string('-', header.Length - 2)}:";

    private static string BuildStatistics(SortedDictionary<string, int> statisticsMap)
    {
        var separator = "|";
        var statisticsLines = new[]
        {
            new StringBuilder(separator),
            new StringBuilder(separator),
            new StringBuilder(separator)
        };

        foreach (var kvp in statisticsMap)
        {
            var headerColumn = GetStatisticsColumnHeader(kvp.Key);
            var rowsSeparatorColimn = GetHeaderLineSeparator(headerColumn);
            statisticsLines[0].Append(headerColumn).Append(separator);
            statisticsLines[1].Append(rowsSeparatorColimn).Append(separator);
            statisticsLines[2].Append($" {kvp.Value} ").Append(separator);
        }
        foreach (var line in statisticsLines)
            line.AppendLine();
        return string.Concat(statisticsLines.Select(l => l.ToString()));
    }

    private static string ReadResourceText(string resourceName)
    {
        var assembly = Assembly.GetExecutingAssembly();

        using (Stream stream = assembly.GetManifestResourceStream(resourceName))
        using (StreamReader reader = new StreamReader(stream))
        {
            return reader.ReadToEnd();
        }
    }
}
