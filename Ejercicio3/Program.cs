using System;
using System.Collections.Generic;
namespace Ejercicio3.app
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //var pais; ejemplo de mala declaracion de una variable
            Pais pais = new()
            {// crear un objeto o instanciar un objeto Inferencia
                PaisId = 1,
                Nombre = "Ecuador"
            };
            pais.Provincias = new List<Provincia>();// lista
            var provincia1 = new Provincia();
            provincia1.Nombre = "Guayas";

            var provincia2 = new Provincia();
            provincia2.Nombre = "Pichincha";

            pais.Provincias = new List<Provincia>()// lista
            {
                provincia1,
                provincia2
            };

            var canton1 = new Canton();
            canton1.Nombre = "Mejia";

            var canton2 = new Canton();
            canton2.Nombre = "Cayambe";

            provincia2.Cantones = new List<Canton>();
            provincia2.Cantones.Add(canton1);
            provincia2.Cantones.Add(canton2);

            var parroquia1 = new Parroquia();
            parroquia1.Nombre = "San Sebastian";

            var parroquia2 = new Parroquia();
            parroquia2.Nombre = "Gonzales Suarez";
            parroquia1.Habitantes = 200;
            parroquia2.Habitantes = 100;

            canton1.Parroquias = new List<Parroquia>();
            canton1.Parroquias.Add(parroquia1);
            canton1.Parroquias.Add(parroquia2);

            Console.WriteLine($" El resultado de los habitantes totales de las 2 parroquias es:{pais.ObtenerNumeroDeHabitantes()}");
        }
    }
}
