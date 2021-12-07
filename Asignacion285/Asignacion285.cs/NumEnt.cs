using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion285.cs
{
    class NumEnt
    {
        public void genNum(int numEnt)
        {
            //Random rnd = new Random();
            //int numEnt = rnd.Next(1, 101);
            int div = numEnt / 2;
            //Console.WriteLine(numEnt);
            Console.ReadLine();
            Console.WriteLine("El numero entero dividido entre dos es igual = " + div);
            Console.ReadKey();
        }

        public uint genNum(uint num)
        {
            uint div = num / 2;
            return div;
            Console.WriteLine(div);
            Console.ReadKey();
        }
    }
}
