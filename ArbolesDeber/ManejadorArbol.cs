namespace ArbolesDeber.app
{
    class ManejadorArbol
        {
        internal string ImprimirCaracteristicasArbol(Nodo nodo, Notacion notacion)
        {
            int contador = 0;
            switch (notacion)
            {
                case Notacion.Niveles:
                
                    foreach (Nodo actual in nodo.Hijos)
                    {
                        contador += actual.Valor.Length;
                    }
                    return contador.ToString();

                case Notacion.Nodos:
                    
                    contador += nodo.raizNodo + nodo.Hijos.Count;
                    foreach (Nodo actual in nodo.Hijos)
                    {
                        contador += actual.Hijos.Count;
                    }
                    return contador.ToString();
                case Notacion.Hojas:
                    
                    foreach (Nodo actual in nodo.Hijos)
                    {
                        contador += actual.Valor.Length + actual.Hijos.Count;
                    }
                    return contador.ToString();

                default:
                    return "Tipo de notacion no implementada";
            }
        }
    }
}


