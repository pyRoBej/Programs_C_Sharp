using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion285.cs
{
     class NumEnt
    {
        public  void genNum(int numEnt)
        {

            int div = numEnt / 2;
            //Console.WriteLine(numEnt);
            Console.ReadLine();
            Console.WriteLine("El numero entero dividido entre dos es igual = " + div);
            Console.ReadKey();

        }

        
        public  void Rndm(int num, out int div)
        {
            div = num / 2;
            Console.WriteLine(div);
            Console.ReadKey();

        }

        public  void Rndm(int numEnt)
        {
            Random rnd = new Random();
            numEnt = rnd.Next(1, 101);
            Console.WriteLine(numEnt);
            Console.ReadKey();

        }



    }
}
