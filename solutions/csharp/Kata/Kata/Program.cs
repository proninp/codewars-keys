using System.IO;

namespace Kata;

public class Program
{
    public static void Main(string[] args)
    {
        KataDocsBuilder.DocsBuilder.BuildReadmeFile(Directory.GetCurrentDirectory());
    }
}