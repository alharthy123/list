using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int>zahl=new List<int>() { 91 , 64 , 50, 64, 89, 78, 64, 36 } ;
            foreach(int i in zahl)
            {
                 Console.Write(" " +i );
            }
            Console.WriteLine();

            zahl.Insert(6, 82);
            foreach(int a in zahl)
            {
              Console.Write(" " +a);
            }
            Console.WriteLine();

            zahl.Remove(36);
            foreach (int g in zahl)
            {
                Console.Write(" " +g );
            }
            Console.WriteLine();
            Console.WriteLine("Anzhl:"+zahl.Count());
            Console.WriteLine("zum ersten mal "+ zahl.IndexOf(64));
            Console.WriteLine("zum letzte mal :"+ zahl.LastIndexOf(64));

        }
    }
}
