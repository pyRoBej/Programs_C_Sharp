﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosLlamada.cs
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Ejercicio Metodos de llamada
            
            //Console.WriteLine("Hola bienvenido, Selecciona un numero para hacer operaciones?");
            //int numero = Convert.ToInt32(Console.ReadLine()); //lee el valor

            //OpsMath ops= new OpsMath();

            //Console.WriteLine("El resultado de la operación suma es: " + ops.suma(numero)); //aqui le estoy diciendo que imprima el texto y le concatene la clase ops con su metodo suma
            //Console.WriteLine("El resultado de la operación resta es: " + ops.resta(numero));
            //Console.WriteLine("El resultado de la operación multiplicación es: " + ops.multp(numero));

            //Console.ReadLine();

            //OpsMath2 ops = new OpsMath2();

            //Console.WriteLine("El resultado de la operación suma es: " + ops.suma(numero) + "\n"); //aqui le estoy diciendo que imprima el texto y le concatene la clase ops con su metodo suma

            //Console.WriteLine("Escriba un numero con decimales para hacer operaciones?");
            //decimal numero2 = Convert.ToDecimal(Console.ReadLine()); //lee el valor
            //Console.WriteLine("El resultado de la operación resta es: " + ops.resta(numero2) + "\n");

            //Console.WriteLine("Escriba un numero para hacer operaciones?");
            //string numero3 = Console.ReadLine(); //lee el valor
            //Console.WriteLine("El resultado de la operación multiplicación es: " + ops.multp(numero3));

            //Console.ReadLine();

            OpsMath3 ops = new OpsMath3();

            Console.WriteLine("Hola, a continuacion haremos una multiplicación, proporcione el primer número");
            int num1 = Convert.ToInt32(Console.ReadLine()); //lee el valor
            Console.WriteLine("\n ... ahora puede proporcionar el segundo número o si lo desea NO HACERLO, de igual forma ya esta proporcionado un valor para el segundo número");
            if (Console.ReadLine() != null)
            {
                int num3 = Convert.ToInt32(Console.ReadLine()); //lee el valor
                Console.WriteLine("El resultado de la multiplicación es: " + ops.multp(num1, num3) + "\n");
            } 
            else if (Console.ReadLine() == null)
            {
                int num2 = 10;
                Console.WriteLine("El resultado de la multiplicación es: " + ops.multp(num1, num2) + "\n");
            }
            Console.ReadLine();

        }
    }
}
