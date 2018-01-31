using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Monopoly
{
    class Joc
    {
        public static List<Strada> strazi = new List<Strada>();
        public static List<Gara> gari = new List<Gara>();
        public static List<Celula> celule = new List<Celula>();
        public static List<Culoare> culori = new List<Culoare>();
        public static List<Jucator> jucatori = new List<Jucator>();
        public static List<Point> locatiiPioni = new List<Point>();
        public static List<PictureBox> pioni = new List<PictureBox>();
        public static Jucator jucatorActiv;
        public static Jucator jucatorTrecut;
        public static bool sfarsitJoc = false;

        public Joc()
        {
            incarcareCelule();
            ListaCelule.Instanta.Sort(Celula.comparare);

            jucatori.Add(new Jucator("masina","filip", 1500));
            jucatori.Add(new Jucator("palarie", "oana", 1500));

            jucatorActiv = jucatori[0];
            jucatori[0].aFost = true;
        }

        public void incarcareCelule()
        {

            string continutFisierStrazi = File.ReadAllText(@"..\..\strazi.json");
            List<Strada> straziIncarcate = JsonConvert.DeserializeObject<List<Strada>>(continutFisierStrazi);

            foreach (var strada in straziIncarcate)
            {
                Celula itemExistent = ListaCelule.Instanta.Find(item => item.Name == parseString(strada.nume));
                if (itemExistent != null)
                {
                    pasareInformatiiStrada(strada, (Strada)itemExistent);
                }
            }

            string continutFisierGari = File.ReadAllText(@"..\..\gari.json");
            List<Gara> gariIncarcate = JsonConvert.DeserializeObject<List<Gara>>(continutFisierGari);

            foreach (var gara in gariIncarcate)
            {
                Celula itemExistent = ListaCelule.Instanta.Find(item => item.Name == parseString(gara.nume));
                if (itemExistent != null)
                {
                    pasareInformatiiGara(gara, (Gara)itemExistent);
                }
            }

            string continutFisierUtilitati = File.ReadAllText(@"..\..\utilitati.json");
            List<Utilitate> utilitatiIncarcate = JsonConvert.DeserializeObject<List<Utilitate>>(continutFisierUtilitati);

            foreach (var utilitate in utilitatiIncarcate)
            {
                Celula itemExistent = ListaCelule.Instanta.Find(item => item.Name == parseString(utilitate.nume));
                if (itemExistent != null)
                {
                    pasareInformatiiUtilitate(utilitate, (Utilitate)itemExistent);
                }
            }

            Sansa.incarcaSanse();

            string continutFisierCartiSpeciale = File.ReadAllText(@"..\..\cartiSpeciale.json");
            List<CarteSpeciala> cartiSpecialeIncarcate = JsonConvert.DeserializeObject<List<CarteSpeciala>>(continutFisierCartiSpeciale);

            foreach (var carteSpeciala in cartiSpecialeIncarcate)
            {
                CarteSpeciala itemExistent = (CarteSpeciala)ListaCelule.Instanta.Find(item => item.Name == parseString(carteSpeciala.nume));
                if (itemExistent != null)
                {
                    //pasareInformatiiCartiSpeciale(carteSpeciala, (Utilitate)itemExistent);
                }
            }

            // Creare culori
            foreach (Celula celula in ListaCelule.Instanta)
            {
                if(celula.GetType() == typeof(Proprietate))
                {
                    Proprietate tempProprietate = (Proprietate)celula;
                    Culoare culoareExistenta = culori.Find(x => x.culoare == tempProprietate.culoare);
                    if(culoareExistenta != null)
                    {
                        culoareExistenta.adaugaProprietate(tempProprietate);
                    } else
                    {
                        Culoare tempCuloare = new Culoare(tempProprietate.culoare);
                        tempCuloare.adaugaProprietate(tempProprietate);
                        culori.Add(tempCuloare);
                    }
                }
            }

            ListaCelule.Instanta.Sort(Celula.comparare);
        }

        private void pasareInformatiiStrada(Strada strada, Strada itemExistent)
        {
            itemExistent.ID = strada.ID;
            itemExistent.nume = strada.nume;
            itemExistent.imagine = strada.imagine;
            itemExistent.culoare = strada.culoare;
            itemExistent.esteIpotecata = strada.esteIpotecata;
            itemExistent.proprietar = strada.proprietar;
            itemExistent.valoareaProprietatii = strada.valoareaProprietatii;
            itemExistent.chirii = strada.chirii;
            itemExistent.pretPerCasa = strada.pretPerCasa;
        }

        private void pasareInformatiiGara(Gara gara, Gara itemExistent)
        {
            itemExistent.ID = gara.ID;
            itemExistent.nume = gara.nume;
            itemExistent.imagine = gara.imagine;
            itemExistent.culoare = "gara";
            itemExistent.esteIpotecata = gara.esteIpotecata;
            itemExistent.proprietar = gara.proprietar;
            itemExistent.valoareaProprietatii = gara.valoareaProprietatii;
        }

        private void pasareInformatiiUtilitate(Utilitate utilitate, Utilitate itemExistent)
        {
            itemExistent.ID = utilitate.ID;
            itemExistent.nume = utilitate.nume;
            itemExistent.imagine = utilitate.imagine;
            itemExistent.culoare = "utilitate";
            itemExistent.esteIpotecata = utilitate.esteIpotecata;
            itemExistent.proprietar = utilitate.proprietar;
            itemExistent.valoareaProprietatii = utilitate.valoareaProprietatii;
        }

        public static string parseString(string stringToParse)
        {
            string stringLowerCase = stringToParse.ToLower();
            return stringLowerCase.Replace(" ", "_").Replace("&", "and").Replace(".", "");
        }
    }
}
