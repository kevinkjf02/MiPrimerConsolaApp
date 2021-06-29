using System;
namespace Arboles.app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello CIPRES!");

            Nodo raiz = new Nodo
            {
                Valor = "*",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "+",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor="8"
                            },
                            new Nodo
                            {
                                Valor="5"
                            }
                        }
                    },
                    new Nodo
                    {
                        Valor="-",
                        Hijos =
                        {
                            new Nodo
                            {
                                Valor="7"
                            },
                            new Nodo
                            {
                                Valor="4"
                            }
                        }
                    }

                }
            };
            //Resultado esperado=>8*5
            // => (8 + 5) * (7 - 4) = 39 Notacion infija
            // => * (+ 8 5) (- 7 4) = 39 Notacion prefija
            // => (8 5 +) (7 4 -) * = 39 Notacion posfija
            ManejadorArbol manejadorArbol = new ManejadorArbol();
            Console.WriteLine(manejadorArbol.ImprimirArbolInfijo(raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPrefijo(raiz));
            Console.WriteLine(manejadorArbol.ImprimirArbolPosfijo(raiz));

            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz,Notacion.Infijo));
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Prefijo));
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz, Notacion.Posfijo));

        }
    }
}
