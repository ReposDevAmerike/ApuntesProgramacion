using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresMate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprimir el resultado de un int mas un double
            Console.WriteLine(5+5);
            int num1 = 7;
            double num2 = 4.5;
            Console.WriteLine(num1+num2);
            //declaro una variable que de ese resultado
            double resultado = num1+num2;
            //y la imprimo
            Console.WriteLine(resultado);
            //resultado alterno
            double resultado2 = num1 + 15;
            //quiero una torta de milanesa bien marrana y gigante con crema 
            //coca light de tres litros pa mi solo 
            Console.WriteLine(resultado2);
            //concatenar strings
            string saludo = "Hola ";
            string nombre = "Fernando";
            Console.WriteLine(saludo + nombre + "Gusto en verte de nuevo");
            Console.WriteLine(saludo + "mucho gusto, un placer en conocerlo, señor " + nombre + " esperamos su estancia");
            //Operador resta 
            Console.WriteLine(50-7);
            //Multiplicador 
            Console.WriteLine(5*5);
            //Division
            Console.WriteLine("////////////////////////////////////////");
            Console.WriteLine(13/2.0f);
            //Comprobacion de numeros decimales
            Console.WriteLine(10/3f);
            Console.WriteLine(10d/3d);
            Console.WriteLine(10m/3m);
            //Residuo o modulo
            Console.WriteLine(10 % 3);
            Console.WriteLine(5.9 % 3.1);
        }
    }
}
