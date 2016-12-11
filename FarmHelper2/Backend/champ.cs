using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmHelper2.Backend
{
    public class Champ
    {

        public static List<Planta> sortare(List<Planta> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                double min = lista[i].scor;
                int t = i;
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[j].scor < min)
                    {
                        min = lista[j].scor;
                        t = j;
                    }
                }

                Planta aux = new Planta("", "", 0, 0, 0, 0);

                aux.nume = lista[i].nume;
                aux.pamant = lista[i].pamant;
                aux.scor = lista[i].scor;
                aux.temperatura = lista[i].temperatura;
                aux.umiditate = lista[i].umiditate;
                aux.tone = lista[i].tone;
                aux.pret = lista[i].pret;

                lista[i].nume = lista[t].nume;
                lista[i].pamant = lista[t].pamant;
                lista[i].scor = lista[t].scor;
                lista[i].temperatura = lista[t].temperatura;
                lista[i].umiditate = lista[t].umiditate;
                lista[i].tone = lista[t].tone;
                lista[i].pret = lista[t].pret;

                lista[t].nume = aux.nume;
                lista[t].pamant = aux.pamant;
                lista[t].scor = aux.scor;
                lista[t].temperatura = aux.temperatura;
                lista[t].umiditate = aux.umiditate;
                lista[t].tone = aux.tone;
                lista[t].pret = aux.pret;
            }

            return lista;
                  
       }

        public static List<Planta> sortare1(List<Planta> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                double max = lista[i].profit;
                int t = i;
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[j].profit > max)
                    {
                        max = lista[j].profit;
                        t = j;
                    }
                }

                Planta aux = new Planta("", "", 0, 0, 0, 0);

                aux.nume = lista[i].nume;
                aux.pamant = lista[i].pamant;
                aux.scor = lista[i].scor;
                aux.temperatura = lista[i].temperatura;
                aux.umiditate = lista[i].umiditate;
                aux.tone = lista[i].tone;
                aux.pret = lista[i].pret;
                aux.profit = lista[i].profit;

                lista[i].nume = lista[t].nume;
                lista[i].pamant = lista[t].pamant;
                lista[i].scor = lista[t].scor;
                lista[i].temperatura = lista[t].temperatura;
                lista[i].umiditate = lista[t].umiditate;
                lista[i].tone = lista[t].tone;
                lista[i].pret = lista[t].pret;
                lista[i].profit = lista[t].profit;

                lista[t].nume = aux.nume;
                lista[t].pamant = aux.pamant;
                lista[t].scor = aux.scor;
                lista[t].temperatura = aux.temperatura;
                lista[t].umiditate = aux.umiditate;
                lista[t].tone = aux.tone;
                lista[t].pret = aux.pret;
                lista[t].profit = aux.profit;
            }

            return lista;

        }

        public static List<Planta> valid(List <Planta> plante)
        {
            while (plante.Count > 5)
            {
                plante.RemoveAt(plante.Count - 1);
            }
            return plante;
        }

        public static List<Planta> calcul(List<Planta> plante)
        {

            foreach (Planta planta in plante)
            {
                planta.procent = Math.Abs(planta.scor - 2) * 50.0;
            }

            foreach (Planta planta in plante)
            {
                planta.tone = (planta.tone * planta.procent) / 100.0;
            }

            foreach (Planta planta in plante)
            {
                planta.profit = planta.tone * planta.pret;
            }

            return plante;

            
        }

        public static List<Planta> best(string sol, int umiditate, int temperatura, int tip)
        {
            List<Planta> lista = FileManager.ReadFile();

            List<Planta> lista_finala = new List<Planta>();

            double scor = 0;

            foreach(Planta planta in lista)
            {
                scor = 0;

                if ((planta.pamant == sol || planta.pamant == "Toate") && Math.Abs(umiditate-planta.umiditate)<=10 && Math.Abs(temperatura-planta.temperatura)<=5)
                {
                    scor = Math.Abs(umiditate-planta.umiditate) / 10.0 + Math.Abs(temperatura-planta.temperatura) / 5.0;
                    planta.scor = scor;
                    lista_finala.Add(planta);
                }
            }

            lista = valid(lista_finala);
            lista = calcul(lista);

            if (tip == 0) lista = sortare(lista);
            if (tip == 1) lista = sortare1(lista);
           
            return lista;
        }

        public static string bestOption(List<Planta> plante)
        {
            string best = "";
            double maxProfit = -1;
            Planta bestPlanta = new Planta("", "", 0, 0, 0, 0);

            foreach (Planta planta in plante)
            {
                if(planta.procent>=50 && planta.profit > maxProfit)
                {
                    maxProfit = planta.profit;
                    bestPlanta = planta;
                }
            }

            best = bestPlanta.nume.ToString() + ": Profit/ha " + bestPlanta.profit.ToString() + " £";

            return best;
        }
    }
}