using System;
namespace ArbolesDeber.app
{
    partial class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienvenidos");
            Console.WriteLine("Hola Cipres!");
            Nodo raiz = new()
            {
                
                Valor = "/",
                Hijos =
                {
                    new Nodo
                    {
                        Valor="*",
                        Hijos=
                        {
                            new Nodo
                            {
                                Valor="2"
                            },
                            new Nodo{
                                Valor="1"
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor ="+",
                        Hijos={
                            new Nodo{
                                Valor="9"
                            },
                            new Nodo{
                                Valor="20"
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor ="-",
                        Hijos={
                            new Nodo{
                                Valor="7"
                            },
                        }
                    },
                }
            };
            ManejadorArbol manejadorArbol = new();
            Console.WriteLine($"{"Los niveles de nodos son: " + "\n"} {manejadorArbol.ContarNumeroNiveles(raiz)}");
            Console.WriteLine($"{"El numero de hojas es: " + "\n"} {manejadorArbol.ContarNumeroHojas(raiz)}");
            Console.WriteLine($"{"El numero de Nodos es: " + "\n"} {manejadorArbol.ContarNumeroNodos(raiz)}");
            Console.ReadLine();
        }
    }
}
