using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public class Strada : Proprietate
    {
        private int numarCase = 0;
        public int[] chirii { get; set; }
        public int pretPerCasa { get; set; }

        [JsonConstructor]
        public Strada(int ID, string nume, int valoareaProprietatii, string culoare, int[] chirii, int pretPerCasa, string imagineaProprietatii) : base(ID, nume, valoareaProprietatii, culoare, imagineaProprietatii)
        {
            this.chirii = chirii;
            this.pretPerCasa = pretPerCasa;
        }

        public Strada()
        {
            ListaCelule.Instanta.Add(this);
        }

        public bool adaugaCasa()
        {
            foreach(Strada stradaCurenta in Joc.strazi)
            {
                // Daca au aceeasi culoare, acelasi proprietar si nume diferit, verificam numarul de case
                if(stradaCurenta.culoare == this.culoare && stradaCurenta.proprietar == this.proprietar && stradaCurenta.nume != this.nume)
                {
                    // Daca diferenta dintre numarul de case ale celor doua proprietati in modul e mai mica decat 1,
                    // putem adauga o casa
                    if(Math.Abs(stradaCurenta.numarCase-this.numarCase) <= 1)
                    {
                        this.numarCase++;
                        this.proprietar.bani -= this.pretPerCasa;
                        return true;
                    }
                }
            }
            return false;
        }

        public new void activeaza(Jucator jucator)
        {
            if(proprietar == null)
            {
                var tempAfisareCelula = new AfisareCelula(this.imagine);
                var confirmResult = MessageBox.Show($"Vrei sa cumperi {this.nume} pentru {this.valoareaProprietatii} ?",
                                     "Cumpara!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    proprietar = jucator;
                    jucator.numarUtilitati++;
                    jucator.bani -= valoareaProprietatii;
                    jucator.proprietatiDetinute.Add(this);
                    tempAfisareCelula.Close();

                }
            }
            else if(proprietar != jucator)
            {
                int dePlata = chirie(proprietar);
                var informarePlata = MessageBox.Show($"Trebuie sa platesti {dePlata} jucatorului {proprietar.nume}",
                            "Da cu zarul",
                            MessageBoxButtons.OK);
                jucator.plateste(proprietar, chirie(proprietar));
            }
        }

        public override int chirie(Jucator proprietar)
        {
            int nrProprietatiTotale = 0;
            int nrProprietatiDetinute = 0;
            Culoare tempCuloare = Joc.culori.Find(x => x.culoare == this.culoare);
            foreach (Strada strada in tempCuloare.proprietati)
            {
                nrProprietatiTotale++;
                if(strada.proprietar == proprietar)
                {
                    nrProprietatiDetinute++;
                }
            }
            if(nrProprietatiDetinute == nrProprietatiTotale)
            {
                if(numarCase > 0)
                {
                    return chirii[numarCase];
                } else
                {
                    return 2 * chirii[0];
                }
            } else
            {
                return chirii[0];
            }
        }
    }
}
