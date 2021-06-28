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
            Console.WriteLine($"{"El numero de Niveles es: " + "\n"} {manejadorArbol.ImprimirCaracteristicasArbol(raiz, Notacion.Niveles )}");
            Console.WriteLine($"{"El numero de Hojas es: " + "\n"} {manejadorArbol.ImprimirCaracteristicasArbol(raiz, Notacion.Hojas)}");
            Console.WriteLine($"{"El numero de Nodos es:" + "\n"} {manejadorArbol.ImprimirCaracteristicasArbol(raiz, Notacion.Nodos)}");
            Console.ReadLine();
        }
    }
}
