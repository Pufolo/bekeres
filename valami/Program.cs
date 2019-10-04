using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valami
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bekertSzamok = new List<int>();
            //darabszám
            Console.WriteLine("Hány darab elemet szeretne megadni?");
            int elemSzam = Convert.ToInt32(Console.ReadLine());
            //bekérés
            for (int i = 0; i < elemSzam; i++)
            {
                Console.WriteLine("Kérem adjon meg egy számot!");
                bekertSzamok.Add(Convert.ToInt32(Console.ReadLine()));
            }
        }
    }
}
