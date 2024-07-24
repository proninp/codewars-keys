using System;
using System.IO.IsolatedStorage;
using System.Linq;
using _6kyu.Array.diff;
using _6kyu.The_PaperFold_sequence;

namespace _6kyu
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int test = 20;
            for (int i = 1; i <= test; i++)
            {
                var seq = ThePaperFoldSequence.PaperFold();
                foreach (var p in seq)
                    Console.Write(p + ", ");
                
            }

        }
    }
}
