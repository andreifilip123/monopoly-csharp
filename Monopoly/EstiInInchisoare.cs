using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class EstiInInchisoare : Form
    {
        Jucator jucatorInInchisoare;

        public EstiInInchisoare(Jucator jucator)
        {
            InitializeComponent(jucator);
            jucatorInInchisoare = jucator;
            jucatorInInchisoare.eInInchisoare = true;
        }

        private void dauCuZarul_Click(object sender, EventArgs e)
        {
            if(jucatorInInchisoare.tureInInchisoare < 3)
            {
                Zar zar = new Zar();
                if (zar.zar1 == zar.zar2)
                {
                    jucatorInInchisoare.eInInchisoare = false;
                }
                else
                {
                    jucatorInInchisoare.tureInInchisoare++;
                }
            } else
            {
                MessageBox.Show("Ai stat deja 3 ture in inchisoare. Trebuie sa platesti 50");
                jucatorInInchisoare.bani -= 50;
                jucatorInInchisoare.eInInchisoare = false;
            }
        }
    }
}
