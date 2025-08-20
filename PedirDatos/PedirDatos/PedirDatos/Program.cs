using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedirDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola");
            string saludo = "Mucho Gusto";
            char letra = 'C';
            Console.WriteLine(saludo);
            Console.WriteLine(letra);
            double i = 7.9;
            Console.WriteLine(i+3);
            int entero = 35;
            Console.WriteLine(entero);
            // cadena de formato
            //parte 2
            double precioconsola = 7500;
            string colorconsola = "negra";
            Console.WriteLine($"El precio de la consola es de { precioconsola} y el color es { colorconsola}");
            Console.WriteLine("EL precio de la consola es: {0} y su color es {1}",precioconsola,colorconsola);
            //Datos personales que pidio el profe
            string nombre = "Jesús";
            string apellido = "Zavala";
            int edad = 16;
            string direccion = "Bonampak 9";
            string telefono = "221 868 1458";
            //no me se mi codigo postal porque recien me mude
            Console.WriteLine($"{saludo} Mi nombre es: {nombre}, me apellido: {apellido} tengo {edad} años, vivo en {direccion}");
            Console.WriteLine($"Me puedes llamar al {telefono}");
            
        }
    }
}
