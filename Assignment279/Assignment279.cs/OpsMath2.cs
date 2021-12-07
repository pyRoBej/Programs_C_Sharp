using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment279.cs
{
    class OpsMath2
    {
        public int suma(int num)    //el cambiar void por int significa que me va a regresar un valor, si dejo void le estaria diciendo
                                    //que no devuelve nada, ademas para que no marque error debo cumplir este retorno, por eso
                                    //dentro del metodo se pone el return result
        {
            int result = num + 10;
            return result;
        }

        public int suma(decimal num)
        {
            int result = Convert.ToInt32(num) - 2;
            return result;
        }

        public int suma(string num)
        {
            int result = Convert.ToInt32(num) * 10;
            return result;
        }
    }
}
