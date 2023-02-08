using System;
using Proyecto;

namespace Proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menuOperaciones = new Menu();
            menuOperaciones.menuPrincipal();
            Console.ReadKey();
        }
    }
}
