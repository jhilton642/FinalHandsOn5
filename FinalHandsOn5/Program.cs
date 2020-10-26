using System;

namespace FinalHandsOn5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string userString = Console.ReadLine();
            if (userString.Length > 20)
            {
                Console.WriteLine(userString.Remove(userString.Length / 2));
            }
            else if (userString.Contains('z'))
            {
                userString = userString + " found a 'z'";
                Console.WriteLine(userString);
            }
            else if (userString.StartsWith('a')&&userString.Length>=8)
            {
                string newString = "!!!!!" + userString.Substring(3,5);
                Console.WriteLine(newString);
            }
            else
            {
                userString = userString.ToUpper();
                Console.WriteLine(userString.Replace(' ','_'));
            }
        }
    }
}
