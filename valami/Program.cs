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
            List<int> bekertSz = new List<int>();
            
            Console.WriteLine("Hány darab elemet szeretne megadni?");
            int szam = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < szam; i++)
            {
                Console.WriteLine("Kérem adjon meg egy számot!");
                bekertSz.Add(Convert.ToInt32(Console.ReadLine()));
            }
            
            int max = bekertSz[0];
            for (int i = 0; i < bekertSz.Count; i++)
            {
                if (bekertSz[i] > max)
                {
                    max = bekertSz[i];
                }
            }
        }
    }
}
