using System;
using System.Drawing;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class Form1 : Form
    {
        Joc tempJoc;
        Jucator jucatorActiv = Joc.jucatorActiv;

        public Form1()
        {
            InitializeComponent();
            tempJoc = new Joc();
            foreach(var pion in Joc.pioni)
            {
                this.Controls.Add(pion);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizeazaInformatiile();
        }

        private void rollDice_Click(object sender, EventArgs e)
        {
            Zar tempZar = new Zar();

            zar1.BackgroundImage = tempZar.zar1Image;
            zar2.BackgroundImage = tempZar.zar2Image;

            if(jucatorActiv.numarDuble == 3)
            {
                jucatorActiv.mergiLa(10);
                MessageBox.Show("Ai dat 3 duble la rand ! Mergi la inchisoare !");
            }

            if (tempZar.zar1 == tempZar.zar2)
            {
                MessageBox.Show("Ai dat dubla. Mai dai o data !");
                jucatorActiv.numarDuble++;
            } else
            {
                daCuZarul.Enabled = false;
            }

            jucatorActiv.muta(tempZar.zar1 + tempZar.zar2);

            actualizeazaInformatiile();
        }

        private void actualizeazaInformatiile()
        {
            jucatorActiv = Joc.jucatorActiv;
            numeJucator.Text = jucatorActiv.nume;
            baniJucator.Text = jucatorActiv.bani.ToString();
            pozitieJucator.Text = jucatorActiv.pozitieCurenta.ToString();
            pionJucator.BackgroundImage = jucatorActiv.pion;

            zar1.BackgroundImage = null;
            zar2.BackgroundImage = null;
        }

        private void incheieTura_Click(object sender, EventArgs e)
        {
            jucatorActiv.aFost = true;
            Jucator urmatorulJucator = Joc.jucatori.Find(jucator => jucator.aFost == false);
            if(urmatorulJucator != null)
            {
                int indexulJucatoruluiTrecut = Joc.jucatori.IndexOf(jucatorActiv);
                Joc.jucatori[indexulJucatoruluiTrecut] = jucatorActiv;
                
                Joc.jucatorActiv = urmatorulJucator;

                daCuZarul.Enabled = true;

                actualizeazaInformatiile();                
                
            } else
            {
                foreach (Jucator jucator in Joc.jucatori)
                {
                    jucator.aFost = false;
                }
                jucatorActiv = Joc.jucatori.Find(jucator => jucator.aFost == false);

                daCuZarul.Enabled = true;

                actualizeazaInformatiile();
            }
        }
    }
}
