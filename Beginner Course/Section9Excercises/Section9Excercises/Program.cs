using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Section9Excercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Frank\Documents\Git\C#\Beginner Course\Section9Excercises\sample.txt";
            Console.WriteLine("Word Count: " + FileWordCounter(path));
            Console.WriteLine("Longest Word: " + FileLongestWord(path));
        }


        static long FileWordCounter(string path)
        {
            string line;
            var wordList = new List<string>();
            long wordCount;

            try
            {
                // Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(path);

                // Read the first line of text
                line = sr.ReadLine();

                // Continue to read until you reach end of file
                while (line != null)
                {
                    foreach (var word in line.Split(' '))
                    {
                        wordList.Add(word);
                    }

                    // Write the line to console window
                    Console.WriteLine(line);
                    // Read the next line
                    line = sr.ReadLine();
                }
                // Close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                throw;
            }
            finally
            {
                wordCount = wordList.Count();
            }

            return wordCount;
        }

        static string FileLongestWord(string path)
        {
            string line;
            var wordList = new List<string>();
            string largestWord = "";
            int largestWordCount = 0;

            try
            {
                // Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(path);

                // Read the first line of text
                line = sr.ReadLine();

                // Continue to read until you reach end of file
                while (line != null)
                {
                    foreach (var word in line.Split(' '))
                    {
                        wordList.Add(word);
                    }

                    // Write the line to console window
                    Console.WriteLine(line);
                    // Read the next line
                    line = sr.ReadLine();
                }
                // Close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                throw;
            }
            finally
            {
                foreach (var word in wordList)
                {
                    if (word.Length > largestWordCount)
                    {
                        largestWord = word;
                        largestWordCount = word.Length;
                    }
                }
            }

            return largestWord;
        }

    }
}
