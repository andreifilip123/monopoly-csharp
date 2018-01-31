using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class ListaSanse : List<Sansa>
    {
        public static ListaSanse Instanta
        {
            get
            {
                if (lista != null)
                {
                    return lista;
                }
                else
                {
                    lista = new ListaSanse();
                    return lista;
                }
            }
        }
        private static ListaSanse lista;

        private ListaSanse()
        {

        }

        private static Random random = new Random();

        public static void Amesteca()
        {
            int numarSanse = Instanta.Count;
            while (numarSanse > 1)
            {
                numarSanse--;
                int k = random.Next(numarSanse + 1);
                Sansa sansaCurenta = Instanta[k];
                Instanta[k] = Instanta[numarSanse];
                Instanta[numarSanse] = sansaCurenta;
            }
        }
    }
}
