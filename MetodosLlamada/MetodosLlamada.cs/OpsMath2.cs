using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosLlamada.cs
{
    class OpsMath2
    {
        public int suma(int num)    //el cambiar void por int significa que me va a regresar un valor, si dejo void le estaria diciendo
                                    //que no devuelve nada, ademas para que no marque error debo cumplir este retorno, por eso
                                    //dentro del metodo se pone el return result
        {
            int result = num + 10;
            return result;
            //Console.WriteLine("tu numero mas 10 es: " + result);
        }

        public int resta(decimal num)
        {
            int result = Convert.ToInt32(num) - 2;
            return result;
            //Console.WriteLine("tu numero menos 2 es: " + result);
        }

        public int multp(string num)
        {
            int result = Convert.ToInt32(num) * 10;
            return result;
            //Console.WriteLine("tu numero multiplicado por 10 es: " + result);
        }
    }
}
