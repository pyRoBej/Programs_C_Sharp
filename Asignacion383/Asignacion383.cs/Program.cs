using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion383.cs
{
    class Program
    {
        //Los metodos sobrecargados, son metodos que comparten el mismo nombre, pero que reciben diferentes variables en sus argumentos
        static void Main(string[] args)
        {
            //Declaramos nuestro valor constante, osea que no va ser modificable
            const string saludo = "Hola, Tech Academy te saluda ";
            //Variable para guardar una frase personalizada por parte del usuario
            string frase = ", ";

            Console.WriteLine("Sobrecarga de Constructores");

            Console.WriteLine("Ingresa tu nombre para recibir un saludo");
            var nombre = Console.ReadLine();

            ////primer if para decidir que accion executar
            //Console.WriteLine("Quieres agregar una frase? 1: Si  2: No");
            ////creamos la variable resp a la cual le decimos que se asigne el valor leido en consola, el cual convertimos a un entero
            //int resp = int.Parse(Console.ReadLine());

            //if (resp == 2)
            //{
            //    Console.WriteLine(Saludar(saludo, nombre));
            //}


            //if (resp == 1)
            //{
            //    Console.WriteLine("Ingresa la frase: ");
            //    //Sobre carga de variable, por que ya tiene asignado un valor y se le suma lo que se escribe en consola
            //    //Arriba se declara su valor "", por que ya tiene un valor asignado, con el operado += sobrecargamos ese valor (le agregamos mas)
            //    frase += Console.ReadLine();
            //    Console.WriteLine(Saludar(saludo, nombre, frase));
            //}

            //Console.ReadKey();

            Console.WriteLine("Agrega una frase =>  ");
            //creamos la variable resp a la cual le decimos que se asigne el valor leido en consola, el cual convertimos a un entero
            //int resp = int.Parse(Console.ReadLine());
            //Sobre carga de variable, por que ya tiene asignado un valor y se le suma lo que se escribe en consola
            //    //Arriba se declara su valor "", por que ya tiene un valor asignado, con el operado += sobrecargamos ese valor (le agregamos mas)
                frase += Console.ReadLine();
              Console.WriteLine(Saludar(saludo, nombre, frase));
            Console.ReadLine();


            //estos son los metodos sobrecargados que usaremos, tenemos 2 metodos llamados "saludar" pero ambos reciben distintas variables
            //y ambos arrojan distintos resultados
        }
        //public static string Saludar(String Saludo, String nombre)
        //{
        //    //declaramos
        //    string saludocompleto = "";
        //    //sobrecarga de variable, ya la tenemos declarada y con valor asignamos, le agregamos los valores de saludo y nombre y lo retornamos
        //    return saludocompleto += Saludo + nombre;
        //}

        public Saludar(String Saludo, String Nombre, String Frase)
        {
            this.nombre = Nombre;
            this.frase = Frase;

            //string saludocompleto = "";
            ////una sobrecarga simple, le agregamos un espacio para que no se junte el nombre con la frase
            //Nombre += "";
            ////retornamos la frase completa mientras asignamos su valor con la suma de los mensajes
            //return saludocompleto += Saludo + Nombre + Frase;
        }

        public Saludar(): this(Saludo: "", Nombre: "", Frase: "")
        {

        }
        public Saludar (string nombre) : this(Saludo: " ", nombre, Frase: "" )
        {

        }
    }
}
