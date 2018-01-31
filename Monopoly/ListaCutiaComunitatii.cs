using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class ListaCutiaComunitatii: List<CutiaComunitatii>
    {
        public static ListaCutiaComunitatii Instanta
        {
            get
            {
                if (lista != null)
                {
                    return lista;
                }
                else
                {
                    lista = new ListaCutiaComunitatii();
                    return lista;
                }
            }
        }
        private static ListaCutiaComunitatii lista;

        private ListaCutiaComunitatii()
        {

        }

        private static Random random = new Random();

        public static void Amesteca()
        {
            int numarCutiaComunitatii = Instanta.Count;
            while (numarCutiaComunitatii > 1)
            {
                numarCutiaComunitatii--;
                int k = random.Next(numarCutiaComunitatii + 1);
                CutiaComunitatii cutiaComunitatiiCurenta = Instanta[k];
                Instanta[k] = Instanta[numarCutiaComunitatii];
                Instanta[numarCutiaComunitatii] = cutiaComunitatiiCurenta;
            }
        }
    }
}
