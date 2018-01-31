using Newtonsoft.Json;
using System;
using System.Drawing;

namespace Monopoly
{
    public abstract class Proprietate : Celula
    {
        public int valoareaProprietatii { get; set; }
        public bool esteIpotecata { get; set; }
        public string culoare { get; set; }
        public Jucator proprietar { get; set; }

        [JsonConstructor]
        public Proprietate(int ID, string nume, int valoareaProprietatii, string culoare, string imagineaProprietatii) : base(ID, nume, imagineaProprietatii)
        {
            this.valoareaProprietatii = valoareaProprietatii;
            this.culoare = culoare;
        }

        public Proprietate()
        {

        }

        public abstract int chirie(Jucator jucator);

        public void activeaza(Jucator jucator)
        {
            return;
        }
    }
}
