using System;

namespace Vsite.CSharp
{
    // niz kao argument metode
    class Program
    {
        static void SamVrag(string[] bo�jeZapovjedi)
        {
            bo�jeZapovjedi[2] = "Di su pare?";
        }

        static void Main(string[] args)
        {
            string[] parBo�jih = new string[] { "Ne ubij!", "Ne sagrije�i bludno!", "Ne kradi!", };

            foreach (string s in parBo�jih)
                Console.WriteLine(s);

            Console.WriteLine("Nakon poziva metode");

            SamVrag(parBo�jih);

            foreach (string s in parBo�jih)
                Console.WriteLine(s);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
