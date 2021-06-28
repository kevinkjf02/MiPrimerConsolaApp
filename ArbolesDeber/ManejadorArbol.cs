namespace ArbolesDeber.app
{
    class ManejadorArbol
        {
        internal int ContarNumeroNiveles(Nodo nodo)
        {
            int contador = 0;
            foreach (Nodo actual in nodo.Hijos)
            {
                contador += actual.Valor.Length;
            }
            return contador;
        }
        internal int ContarNumeroHojas(Nodo nodo)
        {
            int contador = 0;
            foreach (Nodo actual in nodo.Hijos)
            {
                contador += actual.Valor.Length + actual.Hijos.Count;
            }
            return contador;
        }

        internal int ContarNumeroNodos(Nodo nodo)
        {
            int contador = 0;
            contador += nodo.raizNodo + nodo.Hijos.Count;
            foreach (Nodo actual in nodo.Hijos)
            {
                contador += actual.Hijos.Count;
            }
            return contador;
        } 
    }
}


