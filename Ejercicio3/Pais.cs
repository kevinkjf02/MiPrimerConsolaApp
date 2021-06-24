using System.Collections.Generic;
namespace Ejercicio3.app
{
    class Pais
    {
        public int PaisId { get; set; }// creacion de propiedades
        public string Nombre { get; set; }// creacion de propiedades
        public List<Provincia> Provincias { get; set; } = new List<Provincia>(); // creacion de propiedades lista
        public int ObtenerNumeroDeHabitantes() //creacion de metodo
        {
            int acumulador = 0;
            foreach (Provincia actual in Provincias)
            {
                acumulador += actual.ObtenerNumeroDeHabitantes();
            }
            return acumulador;
        }
    }
}

