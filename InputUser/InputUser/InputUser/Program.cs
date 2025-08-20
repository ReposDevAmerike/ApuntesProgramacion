using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int edad;
            string telefono;
            int postal;
            string direccion;
            bool isint = false;
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su Apellido");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su telefono");
            telefono = Console.ReadLine();
            Console.WriteLine("Ingrese su Codigo Postal");
            postal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su direccion:");
            direccion = Console.ReadLine();


        }
    }
}
