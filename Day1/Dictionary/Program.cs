// create a dictionary with key as string and value as string
// add 3 elements to the dictionary
// print the dictionary

using System;
using System.Collections.Generic;

namespace LearnCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter String: ");
            var str = Console.ReadLine();

            Program p = new Program();
            var result = p.Frequency(str);

            foreach (var item in result)
            {
                Console.WriteLine("Key: " + item.Key + ", Value: " + item.Value);
            }
        }

        public Dictionary<string, int> Frequency(string str)
        {
            Dictionary<string, int> dict = new();
            string[] words = str.Split(' ');
            foreach (var word in words)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word] = dict[word] + 1;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }
            return dict;
        }
            
    }
}

// Key: 1, Value: One
