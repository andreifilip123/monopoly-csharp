using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Monopoly
{
    public class CutiaComunitatii
    {
        public string categorie;
        private Dictionary<string, string> categorii;
        public string mesaj;

        public CutiaComunitatii(string categorie, Dictionary<string, string> categorii, string mesaj)
        {
            this.categorie = categorie;
            this.categorii = categorii;
            this.mesaj = mesaj;
        }

        public static void incarcaSanse()
        {
            string continutFisierCutiaComunitatii = File.ReadAllText(@"..\..\cutiaComunitatii.json");
            List<CutiaComunitatii> cutiaComunitatiiIncarcate = JsonConvert.DeserializeObject<List<CutiaComunitatii>>(continutFisierCutiaComunitatii);

            foreach (var cutiaComunitatii in cutiaComunitatiiIncarcate)
            {
                ListaCutiaComunitatii.Instanta.Add(cutiaComunitatii);
            }

            ListaCutiaComunitatii.Amesteca();
        }

        public static void executa(CutiaComunitatii cutiaComunitatii, Jucator jucator)
        {
            string categorieCutiaComunitatii = cutiaComunitatii.categorie;
            string valoareCutiaComunitatii = cutiaComunitatii.categorii[categorieCutiaComunitatii];

            switch (categorieCutiaComunitatii)
            {
                case "mergiLa":
                    {
                        mergiLa(valoareCutiaComunitatii, jucator);
                        break;
                    }
                case "primeste":
                    {
                        primeste(valoareCutiaComunitatii, jucator);
                        break;
                    }
                case "platesteLaBanca":
                    {
                        platesteLaBanca(valoareCutiaComunitatii, jucator);
                        break;
                    }
                case "platesteLaJucatori":
                    {
                        platesteLaJucatori(valoareCutiaComunitatii, jucator);
                        break;
                    }
                case "iesiDinInchisoare":
                    {
                        iesiDinInchisoare(valoareCutiaComunitatii, jucator);
                        break;
                    }
            }
        }

        private static void mergiLa(string valoareCutiaComunitatii, Jucator jucator)
        {
            switch (valoareCutiaComunitatii)
            {
                case "UTILITATE":
                    {
                        if (jucator.pozitieCurenta > 12 && jucator.pozitieCurenta < 28)
                        {
                            jucator.pozitieTrecuta = jucator.pozitieCurenta;
                            jucator.pozitieCurenta = 28;
                            Utilitate water_works = (Utilitate)ListaCelule.Instanta.Find(celula => celula.ID == 28);
                            if (water_works.proprietar != null)
                            {
                                int numarUtilitatiDetinute = water_works.proprietar.numarUtilitati;
                                if (numarUtilitatiDetinute == 2)
                                {
                                    water_works.activeaza(jucator);
                                }
                                else
                                {
                                    water_works.proprietar.numarUtilitati = 2;
                                    water_works.activeaza(jucator);
                                    water_works.proprietar.numarUtilitati = numarUtilitatiDetinute;
                                }
                            }
                        }
                        else
                        {
                            jucator.pozitieTrecuta = jucator.pozitieCurenta;
                            jucator.pozitieCurenta = 12;
                            Utilitate electric_company = (Utilitate)ListaCelule.Instanta.Find(celula => celula.ID == 12);
                            if (electric_company.proprietar != null)
                            {
                                int numarUtilitatiDetinute = electric_company.proprietar.numarUtilitati;
                                if (numarUtilitatiDetinute == 2)
                                {
                                    electric_company.activeaza(jucator);
                                }
                                else
                                {
                                    electric_company.proprietar.numarUtilitati = 2;
                                    electric_company.activeaza(jucator);
                                    electric_company.proprietar.numarUtilitati = numarUtilitatiDetinute;
                                }
                            }
                        }
                        break;
                    }
                case "GARA":
                    {
                        int pozitieJucator = jucator.pozitieCurenta;
                        if (pozitieJucator > 5 && pozitieJucator < 15)
                        {
                            jucator.mergiLa(15);// mergi la urmatoarea gara si platesti odata
                            jucator.muta(0);// mai simulez o miscare pentru a mai plati odata
                        }
                        else if (pozitieJucator > 15 && pozitieJucator < 25)
                        {
                            jucator.mergiLa(25);
                            jucator.muta(0);
                        }
                        else if (pozitieJucator > 25 && pozitieJucator < 35)
                        {
                            jucator.mergiLa(35);
                            jucator.muta(0);
                        }
                        else
                        {
                            jucator.mergiLa(5);
                            jucator.muta(0);
                        }
                        break;
                    }
                case "TREISPATII":
                    {
                        jucator.muta(-3);
                        break;
                    }
                case "INCHISOARE":
                    {
                        jucator.mergiLa(10);
                        break;
                    }
                default:
                    {
                        jucator.mergiLa(ListaCelule.Instanta.Find(celula => Joc.parseString(celula.nume) == valoareCutiaComunitatii.ToLower()).ID);
                        break;
                    }
            }
        }

        private static void primeste(string valoareCutiaComunitatii, Jucator jucator)
        {
            jucator.bani += int.Parse(valoareCutiaComunitatii);
        }

        private static void platesteLaBanca(string valoareCutiaComunitatii, Jucator jucator)
        {
            jucator.bani -= int.Parse(valoareCutiaComunitatii);
        }

        private static void platesteLaJucatori(string valoareCutiaComunitatii, Jucator jucator)
        {
            foreach (Jucator jucatorCurent in Joc.jucatori)
            {
                if (jucatorCurent != jucator)
                {
                    jucator.plateste(jucatorCurent, int.Parse(valoareCutiaComunitatii));
                }
            }
        }

        private static void iesiDinInchisoare(string valoareSansa, Jucator jucator)
        {
            jucator.eInInchisoare = false;
            jucator.pozitieCurenta = 10;
            jucator.numarDuble = 0;
            jucator.tureInInchisoare = 0;
        }
    }
}
