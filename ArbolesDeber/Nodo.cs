using System.Collections.Generic;
namespace ArbolesDeber.app
{
    class Nodo
    {
        public string Valor { get; set; }
        public List<Nodo> Nodos { get; set; } = new List<Nodo>();
        public List<Nodo> Hijos { get; set; } = new List<Nodo>();
        public int Nivel { get; set; }
        public int raizNodo = 1;
    }
}
