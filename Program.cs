using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Pila
{
    internal class Program
    {
        static int tope = -1;
        static int op; 
        static int n;
        static char resp = 's';
        static int[] pila;

        static public void Apilar()
        {
            if (tope == n-1)
            {
                Console.WriteLine("Pila llena ");
            }
            else
            {
                tope++; 
                Console.WriteLine("Ingrese el elemento a apilar: ");
                pila[tope] = Convert.ToInt32(Console.ReadLine());
            }
        }

        static public void Desapilar()
        {
            if (tope == -1)
            {
                Console.WriteLine("Pila vacia ");
            }
            else
            {
                tope--;
                Console.WriteLine("Elemento desapilado " );
            }
        }

        static public void Mostrar()
        {
            if (tope == -1)
            {
                Console.WriteLine("Pila vacía");
            }
            else
            {
                for (int i = tope; i >= 0; i--)
                {
                    Console.WriteLine(pila[i]);
                }
            }
        }
        static void Main(string[] args)
        {
           Console.WriteLine("Ingrese el tamaño de la pila: ");
            n = Convert.ToInt32(Console.ReadLine());
            pila = new int[n];

            while (resp != 'n')
            {
                Console.WriteLine("Seleccione una opción: ");
                Console.WriteLine("1. Apilar ");
                Console.WriteLine("2. Desapilar ");
                Console.WriteLine("3. Mostrar ");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Apilar();
                        break;
                    case 2:
                        Desapilar();
                        break;
                    case 3: Mostrar();
                        break;
                    default:
                        Console.WriteLine("Opción no válida ");
                        break;
                }
                Console.WriteLine("¿Desea continuar? (s/n): ");
                resp = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
