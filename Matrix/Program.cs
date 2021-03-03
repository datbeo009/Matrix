using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int ngang = 0;
            int doc = 0;
            int nganglop = 15;
            int doclop = 10;
            int min = -100;
            int max = 100;

            Random r = new Random();
            while(doc < doclop)
            {
                ngang = 0;
                while(ngang <nganglop)
                {
                    int ra = r.Next(min, max);
                    Console.Write("{0,8}", ra);
                    ngang++;
                }
                Console.WriteLine();
                doc++;

            }
            Console.ReadKey();
        }
        
    }
}
