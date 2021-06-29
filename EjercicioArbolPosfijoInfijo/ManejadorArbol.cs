using System.Linq;

namespace Arboles.app
{
    partial class ManejadorArbol
    {
        // Metodo recursivo, porque se llama asi mismo
        internal string ImprimirArbolInfijo(Nodo nodo)
        {
            //Analiza el comportamiento de una hoja
            if (!nodo.Hijos.Any())
               return nodo.Valor;
               return $"({ImprimirArbolInfijo(nodo.Hijos[0])} {nodo.Valor} {ImprimirArbolInfijo(nodo.Hijos[1] )} )";
        }
        internal string ImprimirArbolPrefijo(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;
            return $"{nodo.Valor} ( {ImprimirArbolPrefijo(nodo.Hijos[0])} {ImprimirArbolPrefijo  (nodo.Hijos[1])} )";
            
        }
        internal string ImprimirArbolPosfijo(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;
            return $"( {ImprimirArbolPosfijo(nodo.Hijos[0])} {ImprimirArbolPosfijo  (nodo.Hijos[1])}) {nodo.Valor}";     
        }

        internal string ImprimirArbol(Nodo nodo, Notacion notacion)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            switch (notacion)
            {
                case Notacion.Infijo:
                    return $"( {ImprimirArbol(nodo.Hijos[0] , notacion)} {nodo.Valor} {ImprimirArbol(nodo.Hijos[1], notacion)})";
                case Notacion.Prefijo:
                    return $"( {nodo.Valor} ( {ImprimirArbol(nodo.Hijos[0], notacion)} {ImprimirArbol(nodo.Hijos[1], notacion)} )";
                case Notacion.Posfijo:
                    return $"( {ImprimirArbol(nodo.Hijos[0], notacion)} {ImprimirArbol(nodo.Hijos[1], notacion)} {nodo.Valor} )";
                default:
                    return "Tipo de notacion no implementada";

            }
        }
    }
}
