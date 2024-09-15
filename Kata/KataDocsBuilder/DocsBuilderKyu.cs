using System.Text;

namespace KataDocsBuilder;
public partial class DocsBuilder
{
    private const string IndexFile = "Index.md";
    private const string StartPattern = "# [";
    private const string EndPattern = "](";

    private static void HandleKyuDirectory(
        string kyuDir,
        SortedDictionary<string, SortedDictionary<string, string>> map,
        SortedDictionary<string, int> statisticsMap)
    {
        var kyuReadmeFiles = Directory.EnumerateFiles(kyuDir, ReadmeFile, SearchOption.AllDirectories);
        var kyuMap = new SortedDictionary<string, SortedDictionary<string, string>>();
        var tasksInKyu = kyuReadmeFiles.Count();

        foreach (string kyuReadme in kyuReadmeFiles)
            HandleReadmeKyuFile(kyuReadme, kyuMap, map);

        var indexFilePath = Path.Combine(kyuDir, IndexFile);
        CreateAndWriteFile(indexFilePath, kyuMap);
        statisticsMap.Add(indexFilePath, tasksInKyu);
    }

    private static void HandleReadmeKyuFile(
        string file,
        SortedDictionary<string, SortedDictionary<string, string>> map,
        SortedDictionary<string, SortedDictionary<string, string>> combinedMap)
    {
        var line = GetFileFirstLine(file);
        if (string.IsNullOrEmpty(line))
            return;

        var taskName = GetTaskName(line);

        string taskUriPath = GetFileUri(file);

        if (string.IsNullOrEmpty(taskName) || string.IsNullOrEmpty(taskUriPath))
            return;

        var firstSymbol = !char.IsDigit(taskName[0]) ? char.ToUpper(taskName[0]).ToString() : "\\#";

        AddKeyValueToCollection(map, firstSymbol, taskName, taskUriPath);
        AddKeyValueToCollection(combinedMap, firstSymbol, taskName, taskUriPath);
    }

    private static string GetFileFirstLine(string fileName)
    {
        using var reader = File.OpenText(fileName);
        var fileFirstLine = reader.ReadLine() ?? string.Empty;
        return fileFirstLine;
    }

    private static string GetTaskName(string line)
    {
        if (!(line.Contains(StartPattern) && line.Contains(EndPattern)))
            return string.Empty;
        int startIndex = line.IndexOf(StartPattern) + StartPattern.Length;
        int endIndex = line.IndexOf(EndPattern);
        return line.Substring(startIndex, endIndex - startIndex);
    }

    private static string GetFileUri(string fileName)
    {
        var directoryName = Path.GetDirectoryName(fileName) ?? string.Empty;
        Uri uri = new Uri(directoryName);
        return Path.Combine(uri.Segments[^2], uri.Segments[^1]);
    }

    private static void AddKeyValueToCollection(SortedDictionary<string, SortedDictionary<string, string>> map, string mainKey, string subKey, string value)
    {
        if (!map.ContainsKey(mainKey))
            map.Add(mainKey, new SortedDictionary<string, string>());

        var subMap = map[mainKey];
        if (map[mainKey].ContainsKey(subKey))
            throw new Exception($"Duplicating the task name [{subKey}] in the directory [{value}]");
        subMap.Add(subKey, value);
    }

    private static void WriteTableOfContent(StreamWriter writer, SortedDictionary<string, SortedDictionary<string, string>> map)
    {
        foreach (var title in map)
        {
            writer.WriteLine($"# {title.Key}");
            foreach (var taskInfo in map[title.Key])
                writer.WriteLine($"- [{taskInfo.Key}]({taskInfo.Value})");
            writer.Write(Environment.NewLine);
        }
    }

    private static void CreateAndWriteFile(string filePath, SortedDictionary<string, SortedDictionary<string, string>> map)
    {
        if (File.Exists(filePath))
            File.Delete(filePath);
        using var writer = new StreamWriter(File.Open(filePath, FileMode.Create), Encoding.UTF8);
        WriteTableOfContent(writer, map);
        writer.Flush();
    }
}
