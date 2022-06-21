using System;
using System.Linq;
using Variable.Models;
namespace Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerveza cerveza = new Cerveza();
            Console.WriteLine("Como deseas nombrar la cerveza?");
            cerveza.Name = Console.ReadLine();
            Console.WriteLine("Que presentacion es la cerveza "+cerveza.Name+"?");
            cerveza.Material=Console.ReadLine();
            Console.WriteLine("Cual es el grado alcoholico de la cerveza " + cerveza.Name + "?");
            cerveza.Grade= byte.Parse(Console.ReadLine());
            Console.WriteLine("Cual es el precio de la cerveza " + cerveza.Name + "?");
            cerveza.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("La cerveza " + cerveza.Name + " es alcoholica?");
            string rstl = Console.ReadLine();
            if(rstl=="SI")
            {
                cerveza.Alocoholic = true;
            }
            else if(rstl=="NO")
            {
                cerveza.Alocoholic = false;
            }
            Console.WriteLine("Nombre de la Cerveza: " + cerveza.Name);
            Console.WriteLine("Presentacion: " + cerveza.Material);
            Console.WriteLine("Grado Alcoholico: " + cerveza.Grade);
            Console.WriteLine("Precio (Bs): " + cerveza.Price);
            Console.WriteLine("Alcoholica: " + cerveza.Alocoholic);
        }
    }
}
