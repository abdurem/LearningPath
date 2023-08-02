using System;

namespace Palindrom{
    class Program{
        public static void Main(string[] args){
            Console.WriteLine("Enter a string to check if it is a palindrome");
            string str = Console.ReadLine();
            string rev = "";
            for(int i = str.Length - 1; i >= 0; i--){
                rev += str[i];
            }
            if(str == rev){
                Console.WriteLine("The string is a palindrome");
            }
            else{
                Console.WriteLine("The string is not a palindrome");
            }
        }
    }
}