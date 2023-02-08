using Proyecto.bean;
using System;

namespace Proyecto
{
    public class Menu
    {
        public void menuPrincipal() 
        {
            
            int option;
            double resultado = 0;
            bool final = false;

            Suma suma = new Suma(0,0);
            Resta resta = new Resta(0,0);
            Multiplicar multiplicacion = new Multiplicar(0,0);
            Division division = new Division(0,0);

            Console.WriteLine("Bienvenido a la Calculadora");
            Console.WriteLine("--------------------------------");
            do
            {
                Console.WriteLine("\n | MENÚ DE OPCIONES |");
                Console.WriteLine("1 -> Suma");
                Console.WriteLine("2 -> Resta");
                Console.WriteLine("3 -> Multiplicación");
                Console.WriteLine("4 -> Divsión");
                Console.WriteLine("5 -> SALIR");
                Console.WriteLine("Elige una Opción");
                Console.Write("");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("\n - SUMA -");
                        Console.WriteLine("--------------------------------");

                        Console.WriteLine("\n Ingrese el Primer Número");
                        Console.Write(" ");
                        suma.setNumeroUno(Convert.ToDouble(Console.ReadLine()));

                        Console.WriteLine("\n Ingrese el Segundo Número");
                        Console.Write(" ");
                        suma.setNumeroDos(Convert.ToDouble(Console.ReadLine()));

                        resultado = suma.metodoSumar(suma.getNumeroUno(), suma.getNumeroDos());

                        Console.WriteLine("\n El resultado es : " + resultado);
                        Console.WriteLine(" " + suma.getNumeroUno() + " + " + suma.getNumeroDos() + " = " + resultado);

                        final = true;
                        break;

                    case 2:
                        Console.WriteLine("\n - RESTA -");
                        Console.WriteLine("--------------------------------");

                        Console.WriteLine("\n Ingrese el Primer Número");
                        Console.Write(" ");
                        resta.setNumeroUno(Convert.ToDouble(Console.ReadLine()));

                        Console.WriteLine("\n Ingrese el Segundo Número");
                        Console.Write(" ");
                        resta.setNumeroDos(Convert.ToDouble(Console.ReadLine()));

                        resultado = resta.metodoRestar(resta.getNumeroUno(), resta.getNumeroDos());

                        Console.WriteLine("\n El resultado es : " + resultado);
                        Console.WriteLine(" " + resta.getNumeroUno() + " - " + resta.getNumeroDos() + " = " + resultado);

                        final = true;
                        break;

                    case 3:
                        Console.WriteLine("\n - MULTIPLICACIÓN -");
                        Console.WriteLine("--------------------------------");

                        Console.WriteLine("\n Ingrese el Primer Número");
                        Console.Write(" ");
                        multiplicacion.setNumeroUno(Convert.ToDouble(Console.ReadLine()));

                        Console.WriteLine("\n Ingrese el Segundo Número");
                        Console.Write(" ");
                        multiplicacion.setNumeroDos(Convert.ToDouble(Console.ReadLine()));

                        resultado = multiplicacion.metodoMultiplicar(multiplicacion.getNumeroUno(), multiplicacion.getNumeroDos());

                        Console.WriteLine("\n El resultado es : " + resultado);
                        Console.WriteLine(" " + multiplicacion.getNumeroUno() + " * " + multiplicacion.getNumeroDos() + " = " + resultado);


                        break;

                    case 4:
                        Console.WriteLine("\n - DIVISIÓN -");
                        Console.WriteLine("--------------------------------");

                        Console.WriteLine("\n Ingrese el Primer Número");
                        Console.Write(" ");
                        division.setNumeroUno(Convert.ToDouble(Console.ReadLine()));

                        Console.WriteLine("\n Ingrese el Segundo Número");
                        Console.Write(" ");
                        division.setNumeroDos(Convert.ToDouble(Console.ReadLine()));

                        resultado = division.metodoDividir(division.getNumeroUno(), division.getNumeroDos());

                        Console.WriteLine("\n El resultado es : " + resultado);
                        Console.WriteLine(" " + division.getNumeroUno() + " / " + division.getNumeroDos() + " = " + resultado);
                        break;

                    case 5:
                        Console.WriteLine("\n NOS VEMOS !");
                        Console.WriteLine(" Vuelva Pronto :) ");
                        break;

                    default:
                        Console.WriteLine("\n - ERROR -");
                        Console.WriteLine("La opción ingresada no es correcta");
                        Console.WriteLine("Vuelve a intentarlo \n");

                        break;
                }
            } while ( option < 1 || option > 5 || final );
        }
    }
}
