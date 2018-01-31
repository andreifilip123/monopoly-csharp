using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Monopoly
{
    public class Pion
    {
        public List<Image> pioni = new List<Image>();
        public Image imaginePion;
        private int pionIndex;

        public enum PionEnum
        {
            caine, cizmar, degetar, masina, palarie, roaba, vapor
        }

        public void incarcarePioni()
        {
            foreach (string numeFisier in Directory.EnumerateFiles(@"..\..\pioni\"))
            {
                Image imaginePionCurent = Image.FromFile(numeFisier);
                pioni.Add(imaginePionCurent);
            }
        }

        public Pion()
        {
            Random numar = new Random();
             pionIndex = numar.Next(1, 7);
        }

        public Pion(string p)
        {
            foreach(var option in Enum.GetValues(typeof(PionEnum)))
            {
                if(option.ToString() == p.ToLower())
                {
                    pionIndex = (int)option;
                }
            }
        }

        public Image getImage()
        {
            incarcarePioni();
            return pioni[pionIndex];
        }
    }
}