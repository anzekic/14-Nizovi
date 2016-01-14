using System;
using System.Windows.Forms;

namespace Vsite.CSharp
{
    // inicijalizacija èlanova niza
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;

            //int[] nizBrojeva;  // deklaracija reference na niz

            int[] nizBrojeva = new int[n];
            foreach (var a in nizBrojeva)
                Console.Write(a);

            //int[] Control[] nizKontrola;  // deklaracija reference na niz 

            Control[] nizKontrola = new Control[n];
            foreach (var a in nizKontrola)
                Console.Write(a);

            // inicijalizacija pojedinih èlanova
            nizKontrola[0] = new Button();
            nizKontrola[1] = new Form();
            nizKontrola[2] = nizKontrola[0];
            nizKontrola[3] = new TextBox();

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine(string.Format("{0}. kontrola: {1}", i, nizKontrola[i]));
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
