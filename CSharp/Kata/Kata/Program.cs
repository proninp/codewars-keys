using System.IO;
using KataReadmeBuilder;

namespace Kata;

public class Program
{
    public static void Main(string[] args)
    {
        ReadmeBuilder.BuildReadmeFile(Directory.GetCurrentDirectory());
    }
}