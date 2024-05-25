using System;

namespace TextAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a paragraph or text: ");
            string inputText = Console.ReadLine();

            
            if (!string.IsNullOrEmpty(inputText))
            {
               
                string[] words = inputText.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                int totalWords = words.Length;
                int totalLetters = 0;

               
                foreach (string word in words)
                {
                    totalLetters += word.Length;
                }

               
                double averageWordLength = totalWords > 0 ? (double)totalLetters / totalWords : 0;

               
                Console.WriteLine($"\nText Analysis Report:");
                Console.WriteLine($"Total number of words: {totalWords}");
                Console.WriteLine($"Average word length: {averageWordLength:F2}");
            }
            else
            {
                Console.WriteLine("No text entered. Please enter some text to analyze.");
            }

            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
