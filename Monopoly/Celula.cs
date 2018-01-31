using System;
using System.Drawing;
using System.Windows.Forms;
using Monopoly.Properties;
using Newtonsoft.Json;

namespace Monopoly
{
    public class Celula : Button
    {
        public int ID { get; set; }
        public string nume { get; set; }
        public Image imagine { get; set; }

        public virtual void activeaza(Jucator jucator)
        {

        }

        [JsonConstructor]
        public Celula(int ID, string nume, string imagine)
        {
            this.ID = ID;
            this.nume = nume;
            this.imagine = (Image)Resources.ResourceManager.GetObject(imagine);
            Click += Celula_Click;
        }

        public Celula()
        {
            //ListaCelule.Instanta.Add(this);
        }

        private void Celula_Click(object sender, EventArgs e)
        {
            new AfisareCelula(imagine);
        }

        public static Comparison<Celula> comparare = (x, y) => x.ID.CompareTo(y.ID);
    }
}