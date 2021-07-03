using System;
using System.Collections.Generic;

namespace Flame {
    class Program {

        static void Main(string[] args) {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Flame recreation for C# made by foraged at 11 pm lol");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Enter the first name.");
            string firstName = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the second name.");
            string secondName = Console.ReadLine().ToLower();

            foreach (char c in firstName.ToCharArray()) {
                if (firstName.Contains(c) && secondName.Contains(c)) {
                    firstName = firstName.Replace(c + "", "");
                    secondName = secondName.Replace(c + "", "");
                }
            }


            Console.WriteLine(firstName + " " + secondName);

            List<string> chars = new List<string>();
            chars.Add("F");
            chars.Add("L");
            chars.Add("A");
            chars.Add("M");
            chars.Add("E");

            int charAmount = (firstName + secondName).Length;
            for (int z = 0; z < 4; z++) {
                int f = 0;

                for (int i = 0; i < (charAmount - 1); i++) {
                    f++;
                    if (f == chars.Count) f = 0;
                }

                chars.RemoveAt(f);
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("The result is " + parseResult(chars[0]));
            Console.WriteLine("---------------------------------------------");
        }

        static string parseResult(string result) {
            if (result == "F") return "Friend";
            if (result == "L") return "Love";
            if (result == "A") return "Affection";
            if (result == "M") return "Marry";
            if (result == "E") return "Enemy";


            return "Error";
        }
    }
}
