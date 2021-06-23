using System.Collections.Generic;
using System.Linq;
namespace Arbol.app
{
    internal class AreaPolitica
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public TipoArea TipoArea { get; set; }
        public int Habitantes { get; set; }
        public List<AreaPolitica> AreaPoliticas { get; set; } = new List<AreaPolitica>();
        public int ObtenerNumeroHabitantes()
        {
            if (!AreaPoliticas.Any())
                return Habitantes;
            else
            {
                int acumulador = 0;
                foreach (AreaPolitica actual in AreaPoliticas)
                    acumulador += actual.ObtenerNumeroHabitantes();
                return acumulador;
            }
        }
    }
}

