using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LlamarDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir nombre al jugador
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Mucho gusto: "+ nombre+ " es un placer");
            //pedir datos numericos
            Console.WriteLine("//////////////////////////////////");
            string entrada;
            int num1 = 5, num2, resultados;
            Console.WriteLine("Que numero vas a sumar?");
            entrada = Console.ReadLine();
            num2 = Convert.ToInt32(entrada);
            resultados = num1 + num2;
            Console.WriteLine(resultados);
            Console.WriteLine("Qué numero vas a sumar?");
            int variable = Convert.ToInt16(Console.ReadLine());
            int resultado2 = 7 + variable;
            Console.WriteLine("El resultado es {0}",resultado2);
            //metodo parse
            Console.WriteLine("Que numero vas a sumar?");
            string entrada2;
            entrada2 = Console.ReadLine();
            int num3, resultado3;
            num3 = Int32.Parse(entrada2);
            resultado3 = num3 + 20;
            Console.WriteLine("El nuevo resultado es {0}",resultado3);

        }
    }
}
