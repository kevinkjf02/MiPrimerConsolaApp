using System.Collections.Generic;
namespace Ejercicio3.app
{
    class Canton
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Parroquia> Parroquias { get; set; } = new List<Parroquia>();   // creacion de propiedades

        public int ObtenerNumeroDeHabitantes()
        {
            int acumulador = 0;
            foreach (Parroquia actual in Parroquias)
            {
                acumulador += actual.Habitantes;
            }
            return acumulador;
        }
    }
}
