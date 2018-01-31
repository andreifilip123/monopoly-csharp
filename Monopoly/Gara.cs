using Newtonsoft.Json;
using System.Drawing;
using System.Windows.Forms;

namespace Monopoly
{
    class Gara : Proprietate
    {
        public static int[] chirii = { 0, 50, 100, 200 };
        public static int pretGara = 200;

        [JsonConstructor]
        public Gara(int ID, string nume, string imagineaProprietatii) : base(ID, nume, pretGara, "gara", imagineaProprietatii)
        {

        }

        public Gara()
        {
            ListaCelule.Instanta.Add(this);
        }

        public void activeaza(Jucator jucator)
        {
            if (proprietar == null)
            {
                var confirmResult = MessageBox.Show($"Vrei sa cumperi {this.nume} pentru {pretGara} ?",
                                     "Cumpara!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    proprietar = jucator;
                    jucator.bani -= pretGara;
                    jucator.numarGari++;
                    jucator.proprietatiDetinute.Add(this);
                }
            }
            else if (proprietar != jucator)
            {
                int dePlata = chirie(proprietar);
                var informarePlata = MessageBox.Show($"Jucatorul {proprietar.nume} are {proprietar.numarGari} deci va trebui sa platesti {dePlata}",
                            $"Ai de plata {dePlata}",
                            MessageBoxButtons.OK);
                jucator.plateste(proprietar, chirie(proprietar));
            }
        }

        public override int chirie(Jucator proprietar)
        {
            return chirii[proprietar.numarGari];
        }
    }
}
