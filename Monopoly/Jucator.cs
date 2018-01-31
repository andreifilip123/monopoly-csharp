using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Monopoly
{
    public class Jucator
    {
        static int baniPrimitiLaGO = 200;
        static int pretIesitInchisoare = 50;
        static int marimeTabelaJoc = 39;
        static int INCHISOARE = 10;

        public String nume;
        public Image pion = new Pion().getImage();
        public PictureBox locatiePion;
        public int tureInInchisoare = 0;
        public int bani;
        public List<Proprietate> proprietatiDetinute;
        private int _pozitieCurenta;
        public int pozitieCurenta  {
            get {
                return _pozitieCurenta;
            }
            set {
                //int temp = pozitieCurenta;
                //while(temp < value)
                //{
                //    Point locatieCurenta = ListaCelule.Instanta.Find(celula => celula.ID == temp).Location;
                //    Joc.pioni[Joc.jucatori.IndexOf(Joc.jucatorActiv)].Location = new Point(locatieCurenta.X, locatieCurenta.Y);
                //    temp++;
                //}
                _pozitieCurenta = value;
            }
}  
        public int pozitieTrecuta=0;

        public int numarGari { get; set; }
        public int numarUtilitati { get; set; }
        public int numarDuble { get; internal set; }

        public bool aFost = false;
        public bool eInInchisoare = false;

        public Jucator(String pion,String nume, int bani)
        {
            pozitieCurenta = 0;
            this.pion = new Pion(pion).getImage();
            PictureBox tempPictureBox = new PictureBox();
            Point locatieInitiala = ListaCelule.Instanta[0].Location;
            //tempPictureBox.Location = new Point(locatieInitiala.X, locatieInitiala.Y);
            tempPictureBox.Location = new Point(1, 1);
            tempPictureBox.BackgroundImage = this.pion;
            tempPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            tempPictureBox.Image = this.pion;
            tempPictureBox.Anchor = (((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            tempPictureBox.Name = $"pionJucator{Joc.jucatori.IndexOf(this)}";
            tempPictureBox.Size = new System.Drawing.Size(49, 50);
            //tempPictureBox.TabIndex = 100000;
            //tempPictureBox.TabStop = false;
            tempPictureBox.BringToFront();
            tempPictureBox.Visible = true;
            locatiePion = tempPictureBox;
            Joc.pioni.Add(locatiePion);
            this.nume = nume;
            this.bani = bani;
            proprietatiDetinute = new List<Proprietate>();
        }

        public void mergiLa(int pozitie)
        {
            if(pozitie == INCHISOARE)
            {
                eInInchisoare = true;
                pozitieCurenta = INCHISOARE;
                numarDuble = 0;
                tureInInchisoare = 0;
            } else
            {
                if(pozitie < pozitieCurenta)
                {
                    muta(pozitieCurenta - pozitie);
                } else if(pozitie > pozitieCurenta)
                {
                    muta(marimeTabelaJoc - pozitieCurenta + pozitie);
                }
            }
        }

        public void muta()
        {
            Zar zar = new Zar();

            int numarPasi = zar.zar1 + zar.zar2;

            pozitieTrecuta = pozitieCurenta;
            pozitieCurenta = pozitieTrecuta + numarPasi;

            if(pozitieCurenta > marimeTabelaJoc)
            {
                bani += baniPrimitiLaGO;
                MessageBox.Show("Ai trecut prin GO ! Ai primit 200 !");
                pozitieCurenta = pozitieCurenta - marimeTabelaJoc - 1;
            }

            Joc.strazi[pozitieCurenta].activeaza(this);
        }

        public void muta(int numarPasi)
        {
            pozitieTrecuta = pozitieCurenta;
            pozitieCurenta = pozitieTrecuta + numarPasi;

            if (pozitieCurenta > marimeTabelaJoc)
            {
                pozitieCurenta = pozitieCurenta - marimeTabelaJoc - 1;
                MessageBox.Show("Ai trecut prin GO ! Ai primit 200 !");
                bani += baniPrimitiLaGO;
            }

            ListaCelule.Instanta.Find(celula => celula.ID == pozitieCurenta).activeaza(this);
        }

        public void plateste(Jucator jucator, int suma)
        {
            jucator.bani += suma;
            bani -= suma;
        }
    }
}
