using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class ListaCelule : List<Celula>
    {
        public static ListaCelule Instanta
        {
            get
            {
                if(lista != null)
                {
                    return lista;
                } else
                {
                    lista = new ListaCelule();
                    return lista;
                }
            }
        }
        private static ListaCelule lista;

        private ListaCelule()
        {

        }
    }
}
