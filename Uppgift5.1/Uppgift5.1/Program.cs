using System;

namespace Uppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meddelanden =
            {
                "Detta är ett program.",
                "Som vi.",
                "Skapar i.",
                "Csharp."
            };

            Console.WriteLine("Här är alla meningar:");
            Console.WriteLine();

            for (int i = 0; i < meddelanden.Length; i++)
            {
                Console.WriteLine(meddelanden[i]);
                Console.WriteLine(); 
            }
        }
    }
}