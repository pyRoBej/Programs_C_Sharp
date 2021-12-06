using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosLlamada.cs
{
    class OpsMath3
    {
        public int multp(int number, int number2=10)    //el cambiar void por int significa que me va a regresar un valor, si dejo void le estaria diciendo
                                    //que no devuelve nada, ademas para que no marque error debo cumplir este retorno, por eso
                                    //dentro del metodo se pone el return result
        {
            //num2 = 10;
            int result = number * number2;
            return result;
            //Console.WriteLine("tu numero mas 10 es: " + result);
        }

    }
}
