using System.IO;

namespace Kata;

public class Program
{
    public static void Main(string[] args)
    {
        KataReadmeBuilder.ReadmeBuilder.BuildReadmeFile(Directory.GetCurrentDirectory());
    }
}