using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class CarteSpeciala : Celula
    {
        public int ID { get; set; }
        public string nume { get; set; }

        [JsonConstructor]
        public CarteSpeciala(int ID, string nume, string imagine) : base(ID, nume, imagine)
        {
            this.ID = ID;
            this.nume = nume;
        }

        public CarteSpeciala()
        {
            ListaCelule.Instanta.Add(this);
        }

        public new void activeaza(Jucator jucator)
        {
            if(nume == "Sansa")
            {
                Sansa tempSansa = ListaSanse.Instanta[0];
                Sansa.executa(tempSansa, jucator);
                ListaSanse.Instanta.Remove(tempSansa);
            } else
            {
                CutiaComunitatii tempCutiaComunitatii = ListaCutiaComunitatii.Instanta[0];
                CutiaComunitatii.executa(tempCutiaComunitatii, jucator);
                ListaCutiaComunitatii.Instanta.Remove(tempCutiaComunitatii);
            }
        }
    }
}
