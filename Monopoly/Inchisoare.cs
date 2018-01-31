using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    class Inchisoare : Celula
    {
        public Inchisoare(int ID, string nume, string imagine) : base(ID, nume, imagine)
        {
        }

        public Inchisoare()
        {
            ListaCelule.Instanta.Add(this);
        }

        public new void activeaza(Jucator jucator)
        {
            return;
        }
    }
}
