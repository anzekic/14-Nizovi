using System;

namespace Vsite.CSharp
{
    // niz kao argument metode
    class Program
    {
        static void SamVrag(string[] božjeZapovjedi)
        {
            božjeZapovjedi[2] = "Di su pare?";
        }

        static void Main(string[] args)
        {
            string[] parBožjih = new string[] { "Ne ubij!", "Ne sagriješi bludno!", "Ne kradi!", };

            foreach (string s in parBožjih)
                Console.WriteLine(s);

            Console.WriteLine("Nakon poziva metode");

            SamVrag(parBožjih);

            foreach (string s in parBožjih)
                Console.WriteLine(s);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
