using System.Collections.Generic;
using System.Drawing;

namespace Monopoly
{
    public class Culoare
    {
        public string culoare { get; set; }
        public List<Proprietate> proprietati { get; set; }
        private int numarProprietati { get; set; }
        private Image image { get; set; }
        
        public Culoare(string culoare)
        {
            this.culoare = culoare;
            proprietati = new List<Proprietate>();
        }

        public void adaugaProprietate(Proprietate proprietate)
        {
            proprietati.Add(proprietate);
        }
    }
}