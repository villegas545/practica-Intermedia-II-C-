using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermedia_II
{
    public class ListaTuplas<T>
    {
        List<T> lista = new List<T>();
        public void Agregar(T tupla)
        {
            lista.Add(tupla);
        }
        public List<T> GetLista()
        {
            return lista;
        }
    }
}
