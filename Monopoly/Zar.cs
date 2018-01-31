using System;
using System.Collections.Generic;
using System.Drawing;
using Monopoly.Properties;

namespace Monopoly
{
    class Zar
    {
        public int zar1 { get; set; }
        public int zar2 { get; set; }
        public Image zar1Image { get; set; }
        public Image zar2Image { get; set; }
        private List<Image> zaruri;

        private void LoadImages()
        {
            zaruri = new List<Image>();
            zaruri.Add(Resources.zar1);
            zaruri.Add(Resources.zar2);
            zaruri.Add(Resources.zar3);
            zaruri.Add(Resources.zar4);
            zaruri.Add(Resources.zar5);
            zaruri.Add(Resources.zar6);
        }

        public Zar()
        {
            Random numar = new Random();
            LoadImages();

            zar1 = numar.Next(1, 7);
            zar2 = numar.Next(1, 7);
            zar1Image = zaruri[zar1 - 1];
            zar2Image = zaruri[zar2 - 1];
        }
    }
}
