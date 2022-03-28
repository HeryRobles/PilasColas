using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Pilas
    {
        private List<string> lista;
        public Pilas()
        {
            lista = new List<string>();
        }

        public void Agregar(string dato)
        {
            lista.Add(dato);
        }

        private bool ValidaVacio()
        {
            return (lista.Count == 0);
        }

        public void Eliminar()
        {
            if (ValidaVacio())
            {
                throw new Exception("La Lista está Vacía");
            }

            lista.RemoveAt(lista.Count - 1);
        }
        
        public string Imprimmir()
        {
            string datos = string.Empty;

            if (ValidaVacio())
            {
                return "La Lista está Vacía";           
            }

            int listCount = lista.Count;    

            for (int i = 0; i < listCount; i++)
            {
                if (i>0)
                {
                    datos += "\n";
                }

                datos += $"[{i}] - {lista[i]}";
            }

            return datos;
        }

    }
}
