using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion285.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio Metodos de llamada asig 285

            Console.WriteLine("Hola, a continuacion haremos una división, proporcione el número al que vamos a dividir entre 2");
            int num1 = Convert.ToInt32(Console.ReadLine()); //lee el valor

            NumEnt num = new NumEnt();  //es la instancia que llama a mi clase NumEnt y al metodo genNum

            num.genNum(num1);               // aqui estoy haciendo llamar al metodo genNum que esta en la clase NumEnt

            int num2;
            num.Rndm(num1, out num2);       //para mandar llamar un metodo de otra clase y tome el valor del parametro
                                            //de salida (out), debo especificar en los parametros el "out"
            Console.WriteLine(num2);

            X.ejemplo(); //cuando una clase es estatica no se puede instanciar, solo se manda llamar,
                         //para hacerlo se pone el nombre de la clase estatica "." (punto) y
                         //el metodo al que queremos llamar
            
        }
    }
}
