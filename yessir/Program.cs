using System;
using System.ComponentModel.Design;
namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> bruhs = new Stack<string>();
            bruhs.Push("steve");
            bruhs.Push("Stewart");
            bruhs.Push("Xander");
            bruhs.Push("Kelly");
            bruhs.Push("Ethan");

            Console.WriteLine("Looking for a certain someone? (y or n)");
            string answer = Console.ReadLine();
            while (answer == "y")
            {
                Console.WriteLine("Enter who you are looking for..");
                string bruhsName = Console.ReadLine();
                if (bruhs.Contains(bruhsName))
                {
                    Console.WriteLine("Yes they were here earlier!");

                }
                else
                {
                    Console.WriteLine("oof seems like you just missed them, I dont even think they were here at all haha.");
                }
                Console.WriteLine("Anyone else I can help you find? (y or n)");
                answer = Console.ReadLine();
                
            }
            Console.WriteLine($" here's your {bruhs.Count()} bruhs");
            foreach (var b in bruhs)
            {
                Console.WriteLine(b);
            }
            string firstBruh = bruhs.Peek();
            Console.WriteLine($" You really wanna remove {firstBruh} from the stack? (y or n)");
            answer = Console.ReadLine();
            while (answer == "y")
            {
                bruhs.Pop();
                firstBruh = bruhs.Peek();
                Console.WriteLine($"wanna remove {firstBruh} from stack? (y or n)");
                Console.ReadLine();
            }
            if (bruhs.Peek() == null)
                Console.WriteLine("Empty Stack");
            else
                Console.WriteLine($"Bruhs available are {bruhs.Count()}");
        }
    }
}