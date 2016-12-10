using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmHelper2.Backend
{
    public class champ
    {

        public static List<Planta> sortare(List<Planta> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                double min = 999999999;
                int t = 0;
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[i].scor < min)
                    {
                        min = lista[i].scor;
                        t = i;
                    }
                }

                Planta aux = new Planta("", "", 0, 0);

                aux.nume = lista[i].nume;
                aux.pamant = lista[i].pamant;
                aux.scor = lista[i].scor;
                aux.temperatura = lista[i].temperatura;
                aux.umiditate = lista[i].umiditate;

                lista[i].nume = lista[t].nume;
                lista[i].pamant = lista[t].pamant;
                lista[i].scor = lista[t].scor;
                lista[i].temperatura = lista[t].temperatura;
                lista[i].umiditate = lista[t].umiditate;

                lista[t].nume = aux.nume;
                lista[t].pamant = aux.pamant;
                lista[t].scor = aux.scor;
                lista[t].temperatura = aux.temperatura;
                lista[t].umiditate = aux.umiditate;

            }

            return lista;
                  
       }

        public static List<Planta> best(string sol, int umiditate, int temperatura)
        {
            List<Planta> lista = new List<Planta>();

            lista = FileManager.ReadFile();

            List<Planta> lista_finala = new List<Planta>();

            double scor = 0;

            foreach(Planta planta in lista)
            {
                scor = 0;

                if (planta.pamant == sol && Math.Abs(umiditate-planta.umiditate)<=10 && Math.Abs(temperatura-planta.temperatura)<=5)
                {
                    scor = (umiditate-planta.umiditate) / 10 + (temperatura-planta.temperatura) / 5;
                    planta.scor = scor;
                    lista_finala.Add(planta);
                }
            }

            return sortare(lista_finala);
            
        }
    }
}