using System;
using System.Collections.Generic;
using System.IO;

namespace VoteCounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] countingVote = sr.ReadLine().Split(',');
                        string candidate = countingVote[0];
                        int vote = int.Parse(countingVote[1]);

                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += vote;
                        }
                        else
                        {
                            dictionary[candidate] = vote;
                        }
                    }

                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}