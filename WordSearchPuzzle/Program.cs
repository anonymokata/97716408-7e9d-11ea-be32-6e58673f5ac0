using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearchPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Word Search Kata !");
            Console.WriteLine("Enter input file path : ");
            string filePath = Console.ReadLine();

            try
            {
                bool flag = false;
                while (!flag)
                {
                    if (File.Exists(filePath))
                    {
                        flag = true;
                        string[] lines = File.ReadAllLines(filePath);
                        string[] words = lines[0].Trim().Split(new char[] { ',', ' ' });
                        List<char[]> matrix = lines.Skip(1)
                            .Select(c => c.Trim().Replace(" ", ",").Replace(",", "").ToCharArray().ToArray())
                            .ToList();

                        WordSearch wordSearch = new WordSearch(matrix);
                        Console.WriteLine("");
                        Console.WriteLine("Entered Matrix : ");

                        foreach (string row in lines.Skip(1))
                        {
                            Console.WriteLine(row.Replace(',', ' '));
                        }

                        Console.WriteLine("");
                        Console.WriteLine("Searching words...");
                        Console.WriteLine("");

                        List<string> output = new List<string>();
                        for (int i = 0; i < words.Length; i++)
                        {
                            List<XY> coordList = wordSearch.Search(words[i].ToUpper());
                            string result = string.Join(",", coordList.Select(c => $"({c.X},{c.Y})"));
                            string outputStr = $"{(i + 1).ToString()}. {words[i]} - {result}";
                            output.Add(outputStr);

                            Console.WriteLine(outputStr);
                        }

                        Console.WriteLine("");
                        Console.WriteLine("Save output (Y/N)?");
                        string response = Console.ReadLine().Trim();
                        if (response == "Y" || response == "y")
                        {
                            string outFilePath = string.Empty;
                            try
                            {
                                outFilePath = Environment.SpecialFolder.ApplicationData + "\\KataWordSearch\\" + $"{DateTime.Now.Ticks.ToString()}.txt";
                                Directory.CreateDirectory(Environment.SpecialFolder.ApplicationData + "\\KataWordSearch\\");
                                File.WriteAllLines(outFilePath, output.ToArray());
                                Process.Start(outFilePath);
                                Console.WriteLine("File saved : " + outFilePath);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Cannot create file/directory at : " + outFilePath);
                                Console.WriteLine("Error Message : " + ex.Message);
                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid! file does not exist");
                        Console.WriteLine("Enter input file path : ");
                        filePath = Console.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error Occured");
                Console.WriteLine("Error Message : " + ex.Message);
            }

            Console.WriteLine("");
            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();

        }
    }
}
