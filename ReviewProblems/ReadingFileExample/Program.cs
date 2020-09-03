using System;
using System.IO;

namespace ReadingFileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Daniel\Desktop\Pride and Prejudice by Jane Austen.txt";

            //string entireBook = File.ReadAllText(filePath);
            string[] allLines = File.ReadAllLines(filePath);

            /*
            //Output 5 lines of the book at a time
            for (int i = 0; i < allLines.Length; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    Console.ReadKey();
                }
                Console.WriteLine(allLines[i]);
            }
            */

            foreach (var line in allLines)
            {
                if(line.Contains("Chapter") == true)
                {
                    Console.ReadKey();
                }
                Console.WriteLine(line);
            }

        }
    }
}
