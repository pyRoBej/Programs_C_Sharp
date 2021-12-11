using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion383_2_.cs
{
    class Program
    {
        //Los metodos sobrecargados, son metodos que comparten el mismo nombre, pero que reciben diferentes variables en sus argumentos
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa tu nombre para recibir un saludo:");

            //generamos nuestro valor constante, un mensaje que siempre va a aparecer y que le mandaremos al constructor que lo acepta
            const string saludoGenerico = " mucho gusto en saludarte!";

            //creamos nuestra varible para recibir el nombre del usuario
            var nombre = Console.ReadLine();


            //creamos un objeto de nuestra clase, en la que vamos a pasar los valores al constructor creado que solo acepta esos valores y deja por default "frase"
            //
            Saludo saludonombre = new Saludo(nombre.ToString(), saludoGenerico);

            //Nuevamente creamos un objeto de nuestra clase, pero esta vez le pasamos todos los valores al constructor que lo acepta
            Saludo saludocompleto = new Saludo(nombre.ToString() + " sigue esforzandote en Tech Academy ", " por favor");

            //Console.WriteLine("Solo nombre: ");
            //mostramos los datos del primer objeto, que solo contiene nombre y mensaje,
            //mostramos frase solo para corroborar que nos agrego la propiedad con el valor por default declarado
            Console.WriteLine(saludonombre.nombre + saludonombre.mensaje + saludonombre.frase);


            //Console.WriteLine("Constructor completo: ");
            //nuevamente mostramos nuestro siguiente objeto, este si tiene los datos completos
            Console.WriteLine(saludocompleto.nombre + saludocompleto.mensaje + saludocompleto.frase);

            Console.ReadKey();


        }

        //Esta es la clase que contiene los constructores encadenados
        class Saludo
        {

            public string nombre;
            public string mensaje;
            public string frase;

            //primer constructor, constructor por default, debe recibir siempre los 3 valores para poder crearlo,
            //si queremos asignar solo una propiedad no podriamos hacerlo ya que a fuerza nos pide los 3 argumentos
            public Saludo(string Nombre, String Mensaje, String Frase)
            {
                this.nombre = Nombre;
                this.mensaje = Mensaje;
                this.frase = Frase;
            }

            //Este constructor nos permitira crear un objeto "Saludo" sin pasarle argumentos, ya que esta encadenado a nuestra clase con valores por default (this)
            public Saludo() : this(Nombre: "", Mensaje: "", Frase: "")
            {
            }

            //constructor que acepta solo nombre, lo mismo que el de arriba solo que este toma el parametro de nombre que ya esta recibiendo
            public Saludo(string nombre) : this(nombre, Mensaje: "", Frase: "") { }

            //construtor que acepta nombre y mensaje, seteando frase por default
            public Saludo(string Nombre, string Mensaje) : this(Nombre, Mensaje, Frase: "") { }

        }


    }
}
