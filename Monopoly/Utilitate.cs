using Newtonsoft.Json;
using System.Drawing;
using System.Windows.Forms;

namespace Monopoly
{
    internal class Utilitate : Proprietate
    {
        public Jucator proprietar;
        public static int[] chirii = { 4, 10 };
        public static int pretUtilitate = 150;

        [JsonConstructor]
        public Utilitate(int ID, string nume, int valoareaProprietatii, string culoare, string imagineaProprietatii) : base(ID, nume, valoareaProprietatii, culoare, imagineaProprietatii)
        {
        }

        public Utilitate()
        {
            ListaCelule.Instanta.Add(this);
        }

        public new void activeaza(Jucator jucator)
        {
            if (proprietar == null)
            {
                var confirmResult = MessageBox.Show($"Vrei sa cumperi {this.nume} pentru {pretUtilitate} ?",
                                     "Cumpara!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    proprietar = jucator;
                    jucator.bani -= pretUtilitate;
                    jucator.numarUtilitati++;
                    jucator.proprietatiDetinute.Add(this);
                }
            }
            else if (proprietar != jucator)
            {
                
                var informare = MessageBox.Show($"Va trebui sa dai cu zarul si sa ii platesti jucatorului {proprietar.nume} de {chirii[proprietar.numarUtilitati]} ori cat dai cu zarul",
                                "Da cu zarul",
                                MessageBoxButtons.OK);
                if(informare == DialogResult.OK)
                {
                    int dePlata = chirie(proprietar);
                    var informarePlata = MessageBox.Show($"Ai dat cu zarul {dePlata / proprietar.numarUtilitati} deci va trebui sa platesti {dePlata}",
                                $"Ai de plata {dePlata}",
                                MessageBoxButtons.OK);
                    jucator.plateste(proprietar, dePlata);
                }
            }
        }
        
        public override int chirie(Jucator proprietar)
        {
            Zar zar = new Zar();
            return proprietar.numarUtilitati * (zar.zar1 + zar.zar2);
        }
    }
}