using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Monopoly
{
    public class Sansa
    {
        public string categorie;
        private Dictionary<string, string> categorii;
        public string mesaj;

        public Sansa(string categorie, Dictionary<string,string> categorii, string mesaj)
        {
            this.categorie = categorie;
            this.categorii = categorii;
            this.mesaj = mesaj;
        }

        public static void incarcaSanse()
        {
            string continutFisierSanse = File.ReadAllText(@"..\..\sanse.json");
            List<Sansa> sanseIncarcate = JsonConvert.DeserializeObject<List<Sansa>>(continutFisierSanse);

            foreach (var sansa in sanseIncarcate)
            {
                ListaSanse.Instanta.Add(sansa);
            }

            ListaSanse.Amesteca();
        }

        public static void executa(Sansa sansa, Jucator jucator)
        {
            string categorieSansa = sansa.categorie;
            string valoareSansa = sansa.categorii[categorieSansa];

            switch (categorieSansa)
            {
                case "mergiLa":
                    {
                        mergiLa(valoareSansa, jucator);
                        break;
                    }
                case "primeste":
                    {
                        primeste(valoareSansa, jucator);
                        break;
                    }
                case "platesteLaBanca":
                    {
                        platesteLaBanca(valoareSansa, jucator);
                        break;
                    }
                case "platesteLaJucatori":
                    {
                        platesteLaJucatori(valoareSansa, jucator);
                        break;
                    }
                case "iesiDinInchisoare":
                    {
                        iesiDinInchisoare(valoareSansa, jucator);
                        break;
                    }
            }
        }

        private static void mergiLa(string valoareSansa, Jucator jucator)
        {
            switch (valoareSansa)
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
                        } else if(pozitieJucator > 15 && pozitieJucator < 25)
                        {
                            jucator.mergiLa(25);
                            jucator.muta(0);
                        } else if(pozitieJucator > 25 && pozitieJucator < 35)
                        {
                            jucator.mergiLa(35);
                            jucator.muta(0);
                        } else
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
                        jucator.mergiLa(ListaCelule.Instanta.Find(celula => Joc.parseString(celula.nume) == valoareSansa.ToLower()).ID);
                        break;
                    }
            }
        }

        private static void primeste(string valoareSansa, Jucator jucator)
        {
            jucator.bani += int.Parse(valoareSansa);
        }

        private static void platesteLaBanca(string valoareSansa, Jucator jucator)
        {
            jucator.bani -= int.Parse(valoareSansa);
        }

        private static void platesteLaJucatori(string valoareSansa, Jucator jucator)
        {
            foreach(Jucator jucatorCurent in Joc.jucatori)
            {
                if(jucatorCurent != jucator)
                {
                    jucator.plateste(jucatorCurent, int.Parse(valoareSansa));
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
