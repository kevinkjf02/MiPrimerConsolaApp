using System;
using System.Threading.Tasks;

namespace KevinFuerezExamenWeb.Entities
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }

        public string Nombre { get; set; }

        public Pareja Pareja { get; set; }
    }
}
